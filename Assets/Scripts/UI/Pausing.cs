using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.UI;

public class Pausing : MonoBehaviour
{
    public bool isPaused = false;
    public GameObject PauseMenu;
    public PlayerInput playerInput;
    public PlayerController playerController;
    void Awake()
    {
        playerController = playerController.GetComponent<PlayerController>();
        Resume();
    }
    private void Pause(InputAction.CallbackContext ctx)
    {
        if(!ctx.performed){ return; }
        if(isPaused)
            Resume();
        if(!isPaused)
            Pause();
    }

    
    public void Resume()
    {
        PauseMenu.SetActive(false);
        Time.timeScale = 1f;
        isPaused = false;
        playerInput.SwitchCurrentActionMap("Gameplay");
        playerController.enabled = true;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }
    public void Pause()
    {
        PauseMenu.SetActive(true);
        Time.timeScale = 0f;
        isPaused = true;
        playerInput.SwitchCurrentActionMap("Menu");
        playerController.enabled = false;
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }
}