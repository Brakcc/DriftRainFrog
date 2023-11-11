using UnityEngine;

public abstract class AEntity : MonoBehaviour
{
    #region accessors to herit
    public abstract bool CanMove { get; set; }
    public abstract EntitySO EntityData { get; set; }
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
        rb.AddForce(Vector2.up * EntityData.Power);
        rb.GetComponent<Unit>().OnRelease();
    }
    #endregion
}
