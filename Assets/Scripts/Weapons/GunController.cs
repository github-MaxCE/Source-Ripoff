using System.Collections;
using UnityEngine;
using UnityEngine.InputSystem;

public class GunController : MonoBehaviour
{
    public new Camera camera;
    public CharacterController characterController;
    public bool shotgun;
    public int maxammopool = 20;
    public int curusableammo = 0;
    public int curammopool;
    public int minimumammorequiredtoshoot;
    public float reloadtime = 0.917f;
    private bool isReloading = false;
    public int pellets;
    public float maxspread;
    public float damage = 10f;
    public float range = 10000000f;
    public Animator animator;
    public GameObject bullethole;
    public Pausing pausing;
    void Awake()
    {
        characterController = GameObject.Find("Player").GetComponent<CharacterController>();
    }

    void Start()
    {
        curammopool = maxammopool;
    }
    void OnEnable()
    {
        isReloading = false;
    }
    public void Attack(InputAction.CallbackContext ctx)
    {
        if (!ctx.performed) { return; }
        if(!pausing.isPaused)
            if(shotgun == true)
                shotgunFire();
            else
                Fire();
    }
    private void shotgunFire()
    {
        if(curusableammo >= minimumammorequiredtoshoot)
        {
            for(int i = 0; i < pellets; i++)
            {
                Vector3 direction = transform.forward + new Vector3(Random.Range(-maxspread,maxspread), Random.Range(-maxspread,maxspread), Random.Range(-maxspread,maxspread));

                RaycastHit hitinfo;
                animator.Play("BaseLayer.fire");
                if(Physics.Raycast(camera.transform.position, direction, out hitinfo))
                {
                    hitinfo.transform.SendMessage("shot", damage);
                    hitinfo.transform.SendMessage("shotinfo", hitinfo);
                    GameObject bH = Instantiate(bullethole, hitinfo.point + new Vector3(0f, 0f, -.02f), Quaternion.LookRotation(-hitinfo.normal));
                }
            }
            curusableammo = curusableammo - minimumammorequiredtoshoot;
        }
    }
    void Fire()
    {
        if(curusableammo >= minimumammorequiredtoshoot)
        {
            RaycastHit hitinfo;
            animator.Play("BaseLayer.fire");
            if(Physics.Raycast(camera.transform.position, camera.transform.forward, out hitinfo))
            {
                hitinfo.transform.SendMessage("shot", damage);
                hitinfo.transform.SendMessage("shotinfo", hitinfo);
                GameObject bH = Instantiate(bullethole, hitinfo.point + new Vector3(0f, 0f, -.02f), Quaternion.LookRotation(-hitinfo.normal));
            }
            curusableammo = curusableammo - minimumammorequiredtoshoot;
        }
    }
    IEnumerator Reload()
    {
        isReloading = true;
        animator.SetBool("isReloading", true);
        yield return new WaitForSeconds(reloadtime);
        curammopool = curammopool - 2;
        curusableammo = curusableammo + 2;
        animator.SetBool("isReloading", false);

        isReloading = false;
    }
    private void Update()
    {
        if(!isReloading)
        {
            if(curusableammo == 0 && curammopool >= minimumammorequiredtoshoot)
            {
                StartCoroutine(Reload());
            }
        }
        bool isWalking = animator.GetBool("isWalking");
        if(characterController.isGrounded)
        {
            if(!isWalking && Cmd.forwardMove == 1)
            {
                animator.SetBool("isWalking", true);
                animator.SetFloat("walk", 1f);
            }
            if(!isWalking && Cmd.rightMove == 1)
            {
                animator.SetBool("isWalking", true);
                animator.SetFloat("walk", 1f);
            }
            if(!isWalking && Cmd.forwardMove == -1)
            {
                animator.SetBool("isWalking", true);
                animator.SetFloat("walk", -1f);
            }
            if(!isWalking && Cmd.rightMove == -1)
            {
                animator.SetBool("isWalking", true);
                animator.SetFloat("walk", -1f);
            }
        }
        if(isWalking && Cmd.forwardMove == 0 && Cmd.rightMove == 0)
        {
            animator.SetBool("isWalking", false);
            animator.SetFloat("walk", 1f);
        }
    }
}