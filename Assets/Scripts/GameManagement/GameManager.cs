using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    #region fields
    //UIs
    [SerializeField] Text BestScore;
    [SerializeField] Text currentScore;

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
    private void Start()
    {
        LoadPlayer();
        InitsGameScene();
    }

    private void Update()
    {
        
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
        
    }
    #endregion

    #region Saves
    public void SaveAll()
    {
        SavePlayerData.SavePlayer(this);
    }

    private void OnApplicationQuit()
    {
        SaveAll();
    }
    #endregion

    #region Loadings
    public void LoadPlayer()
    {
        
    }
    #endregion
}
