/*
 * - Edited by PrzemyslawNowaczyk (11.10.17)
 *   -----------------------------
 *   Deleting unused variables
 *   Changing obsolete methods
 *   Changing used input methods for consistency
 *   -----------------------------
 *
 * - Edited by NovaSurfer (31.01.17).
 *   -----------------------------
 *   Rewriting from JS to C#
 *   Deleting "Spawn" and "Explode" methods, deleting unused varibles
 *   -----------------------------
 * Just some side notes here.
 *
 * - Should keep in mind that idTech's cartisian plane is different to Unity's:
 *    Z axis in idTech is "up/down" but in Unity Z is the local equivalent to
 *    "forward/backward" and Y in Unity is considered "up/down".
 *
 * - Code's mostly ported on a 1 to 1 basis, so some naming convensions are a
 *   bit fucked up right now.
 *
 * - UPS is measured in Unity units, the idTech units DO NOT scale right now.
 *
 * - Default values are accurate and emulates Quake 3's feel with CPM(A) physics.
 *
 */


using System;
using UnityEngine;
using UnityEngine.InputSystem;

// Contains the command the user wishes upon the character

public struct Cmd
{
    public static float forwardMove;
    public static float rightMove;
    public static bool Jumps;
}

public class PlayerController : MonoBehaviour
{
    public Transform playerView;     // Camera
    [Range(0, 2)]public float playerViewYOffset = 0.6f; // The height at which the camera is bound to
    /*print() style */
    public GUIStyle style;
    /*FPS Stuff */
    public float fpsDisplayRate = 4.0f; // 4 updates per sec
    private int frameCount = 0;
    private float dt = 0.0f;
    private float fps = 0.0f;
    private CharacterController _controller;
    // Camera rotations
    private Vector3 moveDirectionNorm = Vector3.zero;
    private Vector3 playerVelocity;
    private float playerTopVelocity = 0.0f;
    // Used to display real time fricton values
    private float playerFriction = 0.0f;
    // Player commands, stores wish commands that the player asks for (Forward, back, jump, etc)
    LayerMask player;

    float x;
    float y;

    

    private void Start()
    {
        // Hide the cursor
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        // Put the camera inside the capsule collider
        _controller = GetComponent<CharacterController>();
        player = this.gameObject.layer;
        playerView.position = new Vector3(
            transform.position.x,
            transform.position.y + playerViewYOffset,
            transform.position.z);
        _controller.Move(transform.InverseTransformVector(_controller.transform.position));
        this.transform.rotation = Quaternion.Euler(0, this.transform.rotation.y, 0); // Rotates the collider
        playerView.rotation     = Quaternion.Euler(playerView.rotation.x, playerView.rotation.y, 0); // Rotates the camera
    }

    private void FixedUpdate()
    {
        // Do FPS calculation
        frameCount++;
        dt += Time.deltaTime;
        if (dt > 1.0 / fpsDisplayRate)
        {
            fps = Mathf.Round(frameCount / dt);
            frameCount = 0;
            dt -= 1.0f / fpsDisplayRate;
        }
        /* Movement, here's the important part */
        if(!Settings.noclip)
        {
            if(_controller.isGrounded)
                GroundMove();
            else if(!_controller.isGrounded)
                AirMove();
        }
        else
        {
            Noclip();
            playerView.position = new Vector3(
                transform.position.x,
                transform.position.y + playerViewYOffset,
                transform.position.z);
            return;
        }
        // Move the controller
        _controller.Move(playerVelocity * Time.deltaTime);
        /* Calculate top velocity */
        Vector3 udp = playerVelocity;
        udp.y = 0.0f;
        if(udp.magnitude > playerTopVelocity)
            playerTopVelocity = udp.magnitude;
        //Need to move the camera after the player has been moved because otherwise the camera will clip the player if going fast enough and will always be 1 frame behind.
        // Set the camera's position to the transform
        playerView.position = new Vector3(
            transform.position.x,
            transform.position.y + playerViewYOffset,
            transform.position.z);
    }
    /*******************************************************************************************************\
    |* MOVEMENT
    \*******************************************************************************************************/
    /**
    * Sets the movement direction based on player input
    */
    public void Move(InputAction.CallbackContext ctx)
    {
        var movementVector = ctx.ReadValue<Vector2>();
        Cmd.rightMove = movementVector.x;
        Cmd.forwardMove = movementVector.y;
    }
    public void Mouse(InputAction.CallbackContext ctx)
    {
        var movementVector = ctx.ReadValue<Vector2>();
        /* Camera rotation stuff, mouse controls this shit */
        x = Mathf.Clamp(x - ((movementVector.y / Screen.width) * Settings.sensitivity * 10f), -90f, 90f);
        y += ((movementVector.x / Screen.height) * Settings.sensitivity * 10f);
        
        this.transform.rotation = Quaternion.Euler(0, y, 0); // Rotates the collider
        playerView.rotation     = Quaternion.Euler(x, y, 0); // Rotates the camera
    }
    public void Jump(InputAction.CallbackContext ctx)
    {
        if (!ctx.performed) { return; }
        if(Cmd.Jumps == false)
            Cmd.Jumps = true;
        else
            return;
    }

    private void Jumpaction()
    {
        while(Cmd.Jumps == true)
        {
            if(_controller.isGrounded)
            {
                playerVelocity.y = Settings.sv_jumpspeed;
                Cmd.Jumps = false;
            }
        }
    }

    /**
    * Execs when the player is in the air
    */
    private void AirMove()
    {
        Physics.IgnoreLayerCollision(0,player,false);
        Vector3 wishdir;
        float wishvel = Settings.sv_airacceleration;
        float accel;
        wishdir =  new Vector3(Cmd.rightMove, 0, Cmd.forwardMove);
        wishdir = transform.TransformDirection(wishdir);
        float wishspeed = wishdir.magnitude;
        wishspeed *= Settings.sv_movespeed;
        wishdir.Normalize();
        moveDirectionNorm = wishdir;
        // CPM: Aircontrol
        float wishspeed2 = wishspeed;
        if (Vector3.Dot(playerVelocity, wishdir) < 0)
            accel = Settings.sv_airdecceleration;
        else
            accel = Settings.sv_airacceleration;
        // If the player is ONLY strafing left or right
        if(Cmd.forwardMove == 0 && Cmd.rightMove != 0)
        {
            if(wishspeed > Settings.sv_sidestrafespeed)
                wishspeed = Settings.sv_sidestrafespeed;
            accel = Settings.sv_sidestrafeacceleration;
        }
        Accelerate(wishdir, wishspeed, accel);
        if(Settings.sv_aircontrol > 0)
            AirControl(wishdir, wishspeed2);
        // !CPM: Aircontrol
        // Apply gravity
        playerVelocity.y -= Settings.sv_gravity * Time.deltaTime;
    }
    /**
    * Air control occurs when the player is in the air, it allows
    * players to move side to side much faster rather than being
    * 'sluggish' when it comes to cornering.
    */
    private void AirControl(Vector3 wishdir, float wishspeed)
    {
        Physics.IgnoreLayerCollision(0,player,false);
        float zspeed;
        float speed;
        float dot;
        float k;
        // Can't control movement if not moving forward or backward
        if(Mathf.Abs(Cmd.forwardMove) < 0.001 || Mathf.Abs(wishspeed) < 0.001)
            return;
        zspeed = playerVelocity.y;
        playerVelocity.y = 0;
        /* Next two lines are equivalent to idTech's VectorNormalize() */
        speed = playerVelocity.magnitude;
        playerVelocity.Normalize();
        dot = Vector3.Dot(playerVelocity, wishdir);
        k = 32;
        k *= Settings.sv_aircontrol * dot * dot * Time.deltaTime;
        // Change direction while slowing down
        if (dot > 0)
        {
            playerVelocity.x = playerVelocity.x * speed + wishdir.x * k;
            playerVelocity.y = playerVelocity.y * speed + wishdir.y * k;
            playerVelocity.z = playerVelocity.z * speed + wishdir.z * k;
            playerVelocity.Normalize();
            moveDirectionNorm = playerVelocity;
        }
        playerVelocity.x *= speed;
        playerVelocity.y = zspeed; // Note this line
        playerVelocity.z *= speed;
    }
    /**
    * Called every frame when the engine detects that the player is on the ground
    */
    private void GroundMove()
    {
        Physics.IgnoreLayerCollision(0,player,false);
        Vector3 wishdir;
        // Do not apply friction if the player is queueing up the next jump
        if (_controller.isGrounded)
        {
            ApplyFriction(1.0f);
        }
        else
        {
            ApplyFriction(0);
        }
        wishdir = new Vector3(Cmd.rightMove, 0, Cmd.forwardMove);
        wishdir = transform.TransformDirection(wishdir);
        wishdir.Normalize();
        moveDirectionNorm = wishdir;
        var wishspeed = wishdir.magnitude;
        wishspeed *= Settings.sv_movespeed;
        Accelerate(wishdir, wishspeed, Settings.sv_runacceleration);
        // Reset the gravity velocity
        playerVelocity.y = -Settings.sv_gravity * Time.deltaTime;
        if(Cmd.Jumps == true)
        {
            Jumpaction();
        }

    }

    private void Noclip()
    {
        Physics.IgnoreLayerCollision(0,player,true);
        Vector3 wishdir;
        // Do not apply friction if the player is queueing up the next jump
        wishdir = new Vector3(Cmd.rightMove, 0, Cmd.forwardMove);
        wishdir = Quaternion.AngleAxis(playerView.eulerAngles.x, new Vector3(1, 0, 0)) * wishdir;
        wishdir = transform.TransformDirection(wishdir);
        wishdir.Normalize();
        _controller.Move(wishdir * Settings.sv_noclipspeed);
        // Reset the gravity velocity
    }
    /**
    * Applies friction to the player, called in both the air and on the ground
    */
    private void ApplyFriction(float t)
    {
        Vector3 vec = playerVelocity; // Equivalent to: VectorCopy();
        float speed;
        float newspeed;
        float control;
        float drop;
        vec.y = 0.0f;
        speed = vec.magnitude;
        drop = 0.0f;
        /* Only if the player is on the ground then apply friction */
        if(_controller.isGrounded)
        {
            control = speed < Settings.sv_rundecceleration ? Settings.sv_rundecceleration : speed;
            drop = control * Settings.sv_friction * Time.deltaTime * t;
        }
        newspeed = speed - drop;
        playerFriction = newspeed;
        if(newspeed < 0)
            newspeed = 0;
        if(speed > 0)
            newspeed /= speed;
        playerVelocity.x *= newspeed;
        playerVelocity.z *= newspeed;
    }
    private void Accelerate(Vector3 wishdir, float wishspeed, float accel)
    {
        float addspeed;
        float accelspeed;
        float currentspeed;
        currentspeed = Vector3.Dot(playerVelocity, wishdir);
        addspeed = wishspeed - currentspeed;
        if(addspeed <= 0)
            return;
        accelspeed = accel * Time.deltaTime * wishspeed;
        if(accelspeed > addspeed)
            accelspeed = addspeed;
        playerVelocity.x += accelspeed * wishdir.x;
        playerVelocity.z += accelspeed * wishdir.z;
    }
    private void OnGUI()
    {
        GUI.Label(new Rect(0, 0, 400, 100), "FPS: " + fps, style);
        var ups = _controller.velocity;
        ups.y = 0;
        GUI.Label(new Rect(0, 15, 400, 100), "Speed: " + Mathf.Round(ups.magnitude * 100) / 100 + "ups", style);
        GUI.Label(new Rect(0, 30, 400, 100), "Top Speed: " + Mathf.Round(playerTopVelocity * 100) / 100 + "ups", style);
    }
}