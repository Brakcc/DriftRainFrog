using UnityEngine;

public class ZoneMult : MonoBehaviour
{
    [SerializeField] float mult;

    void OnTriggerStay2D(Collider2D collision)
    {
        GameManager.gm.CurrentZoneMultiplier = mult;
    }
}