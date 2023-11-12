using UnityEngine;

public abstract class AEntity : MonoBehaviour
{
    #region accessors to herit
    public abstract bool CanMove { get; set; }
    public abstract EntitySO EntityData { get; set; }
    public abstract float ZoneSpeed { get; set; }
    #endregion

    #region methodes to herit
    public virtual void OnSpawn()
    {
        CanMove = true;
    }
    public virtual void OnMove(float speed)
    {
        if (!CanMove) return;
        transform.position += new Vector3(0, speed * Time.deltaTime, 0);
    }
    public virtual void OnCollide(EntityEffectType type, Rigidbody2D rb)
    {
        if (rb.velocity.y >= 0) return;
        AudioManager.ad.PlayClipAt(EntityData.AudioEff, transform.position);
        rb.AddForce(Vector2.up * EntityData.Power);
        if (rb.GetComponent<Unit>().IsLocked) rb.GetComponent<Unit>().OnReleaseForced();
    }
    #endregion
}
