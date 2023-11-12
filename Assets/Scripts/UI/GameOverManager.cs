using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverManager : MonoBehaviour
{
    public GameObject gameOverUI;

    public void ToucheRetry()
    {
        //Recharger la scène
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        //Réactiver les moves du persos et la vie du perso
        gameOverUI.SetActive(false);
    }

    public void ToucheMainMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Menu");
    }

    public void ToucheQuit()
    {
        Application.Quit();
    }
}
