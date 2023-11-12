using UnityEngine;

public class EndGame : MonoBehaviour
{
    [SerializeField] GameObject gameOverUI;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player")) { Time.timeScale = 0.35f; gameOverUI.SetActive(true); }
        if (collision.gameObject.CompareTag("Interactables")) { Destroy(collision.gameObject); }
    }
}
