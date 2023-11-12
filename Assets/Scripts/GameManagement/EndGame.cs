using UnityEngine;
using UnityEngine.UI;

public class EndGame : MonoBehaviour
{
    [SerializeField] GameObject gameOverUI;
    [SerializeField] Text finalScore;
    [SerializeField] Text bestScore;

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player")) { Time.timeScale = 0.35f; gameOverUI.SetActive(true); EndTheGame(); }
        if (collision.gameObject.CompareTag("Interactables")) { Destroy(collision.gameObject); }
    }

    void EndTheGame()
    {
        if (GameManager.gm.CurrentPoints > GameManager.gm.BestPoint)
        {
            GameManager.gm.BestPoint = GameManager.gm.CurrentPoints;
        }
        finalScore.text = GameManager.gm.CurrentPoints.ToString();
        bestScore.text = GameManager.gm.BestPoint.ToString();
    }
}
