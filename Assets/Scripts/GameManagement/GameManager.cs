using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    #region fields
    //UIs
    [SerializeField] Text BestScore;
    [SerializeField] Text currentScore;

    public GameObject Player { get; set; }

    public int BestPoint { get; private set; }
    int currentPoints;

    public static GameManager gm;
    private void Awake()
    {
        LoadPlayer();
        gm = this;
        Cursor.visible = false;
    }
    #endregion

    #region Methodes
    void Start()
    {
        LoadPlayer();
        InitsGameScene();
    }

    void InitsGameScene()
    {
        if (GameObject.FindGameObjectWithTag("Player") != null)
        {
            InitGame();
        }
    }

    void InitGame()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
    }
    #endregion

    #region Saves
    public void SaveAll()
    {
        SavePlayerData.SavePlayer(this);
    }

    void OnApplicationQuit()
    {
        SaveAll();
    }
    #endregion

    #region Loadings
    public void LoadPlayer()
    {
        BestPoint = SavePlayerData.LoadPoints();
    }
    #endregion
}
