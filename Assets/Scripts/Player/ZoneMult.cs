using UnityEngine;

public class ZoneMult : MonoBehaviour
{
    [SerializeField] float mult;
    [SerializeField] float speed;

    void OnTriggerEnter2D(Collider2D collision)
    {
        GameManager.gm.CurrentZoneMultiplier = mult;
        foreach (var i in GameObject.FindObjectsOfType<EntitySpawn>())
        {
            i.bonusSpeed = speed;
        }
    }
}