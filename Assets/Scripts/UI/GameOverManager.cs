using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverManager : MonoBehaviour
{
    public GameObject gameOverUI;

    public void ToucheRetry()
    {
        //Recharger la sc�ne
        GameManager.gm.SaveAll();
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        //R�activer les moves du persos et la vie du perso
        gameOverUI.SetActive(false);
    }

    public void ToucheMainMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Menu");
        GameManager.gm.SaveAll();
    }

    public void ToucheQuit()
    {
        Application.Quit();
    }
}
