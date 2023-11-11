using System.Collections;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using System.IO;

public class MenuStart : MonoBehaviour
{
    [SerializeField] private GameObject settingswindow;
    [SerializeField] private GameObject menuwindow;
    [SerializeField] private GameObject quitwindow;

    [SerializeField] private TMP_Text bestTime;
    [SerializeField] private GameObject tampon;

    void Start()
    {
        string path1 = Application.persistentDataPath + "/datas.data";
        if (!File.Exists(path1))
        {
            GameManager.gm.SaveAll();
            ResetGame();
        }
        Cursor.visible = true;
        settingswindow.SetActive(false);
        InitsUI();
        StartCoroutine(StartTheGame());
    }

    void InitsUI()
    {
        
    }

    IEnumerator StartTheGame()
    {
        yield return new WaitForSeconds(3f);
        menuwindow.SetActive(true);
    }

    #region buttons methodes
    public void StartButton()
    {
        GameManager.gm.SaveAll();
        SceneManager.LoadScene(1);
    }

    public void OpenSettingsButton()
    {
        menuwindow.SetActive(false);
        settingswindow.SetActive(true);
    }

    public void CloseSettingsButton()
    {
        menuwindow.SetActive(true);
        settingswindow.SetActive(false);
    }

    public void ResetGame()
    {
        GameManager.gm.SaveAll();
        CloseSettingsButton();
    }

    public void wantToQuit()
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
