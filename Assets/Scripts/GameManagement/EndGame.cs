using UnityEngine;

public class EndGame : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player")) { Time.timeScale = 0; }
        if (collision.gameObject.CompareTag("Interactables")) { Debug.Log("test"); Destroy(collision.gameObject); }
    }
}
