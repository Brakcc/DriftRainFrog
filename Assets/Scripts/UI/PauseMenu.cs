using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool gameIsPaused = false;

    [SerializeField] private InputActionReference pause;

    [SerializeField] private GameObject pauseMenuUI;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab) || pause.action.WasPressedThisFrame())
        {
            if (gameIsPaused)
            {
                Resume();
            }
            else
            {
                Paused();
            }
        }
    }

    public void Paused()
    {
        //PlayerMovement.instance.enabled = false;
        pauseMenuUI.SetActive(true);

        Cursor.visible = true;

        gameIsPaused = true;
        Time.timeScale = 0;
    }

    public void Resume()
    {
        //PlayerMovement.instance.enabled = true;
        pauseMenuUI.SetActive(false);

        Cursor.visible = false;

        gameIsPaused = false;
        Time.timeScale = 1; 
    }

    public void LoadMainMenu()
    {
        Resume();
        GameManager.gm.SaveAll();
        SceneManager.LoadScene("Menu");
    }
}
