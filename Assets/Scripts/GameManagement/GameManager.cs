using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    #region fields
    //UIs
    //[SerializeField] Text BestScore;
    [SerializeField] Text currentScore;

    public Unit Player { get; set; }

    public float BestPoint { get => bestP; set { bestP = value; } }
    float bestP;
    public float CurrentPoints { get => currentP; private set { currentP = value; } }
    float currentP;

    public float CurrentZoneMultiplier { get; set; }
    public float CurrentFlyNumber { get; set; }
    public int CurrentPointsToAdd { get; private set; }

    float elapsedTime;

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

    void Update()
    {
        ManagePoints();
    }

    void InitsGameScene()
    {
        if (GameObject.FindGameObjectWithTag("Player") != null)
        {
            InitGame();
        }
        elapsedTime = 0;
        CurrentPoints = 0;
        CurrentZoneMultiplier = 1;
        currentScore.text = currentP.ToString();
        CurrentPointsToAdd = 100;
    }

    void InitGame()
    {
        Player = GameObject.FindGameObjectWithTag("Player").GetComponent<Unit>();
    }

    void ManagePoints()
    {
        if (Player.IsDead) return;
        elapsedTime += Time.deltaTime;
        if (elapsedTime >= 1f)
        {
            CurrentPoints += CurrentPointsToAdd * (CurrentZoneMultiplier * (1 + 0.1f * CurrentFlyNumber));
            elapsedTime = 0;
            currentScore.text = ((int)currentP).ToString();
        }
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
