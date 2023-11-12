using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using System.IO;

public class MenuStart : MonoBehaviour
{
    [SerializeField] private GameObject menuwindow;
    [SerializeField] private GameObject quitwindow;

    [SerializeField] private TMP_Text bestTime;

    void Start()
    {
        string path1 = Application.persistentDataPath + "/datas.data";
        if (!File.Exists(path1))
        {
            GameManager.gm.SaveAll();
            ResetGame();
        }
        Cursor.visible = false;
        InitsUI(path1);
        //StartCoroutine(StartTheGame());
    }

    void InitsUI(string path)
    {
        if (File.Exists(path)) { bestTime.text = SavePlayerData.LoadPoints().ToString(); }
    }

    #region buttons methodes
    public void StartButton()
    {
        GameManager.gm.SaveAll();
        SceneManager.LoadScene(1);
    }

    public void ResetGame()
    {
        GameManager.gm.SaveAll();
    }

    public void WantToQuit()
    {
        menuwindow.SetActive(false);
        quitwindow.SetActive(true);
    }

    public void NotQuit()
    {
        menuwindow.SetActive(true);
        quitwindow.SetActive(false);
    }

    public void QuitButton()
    {
        Application.Quit();
    }
    #endregion
}
