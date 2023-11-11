using UnityEngine;

public abstract class AEntity : MonoBehaviour
{
    #region accessors to herit
    public abstract bool CanMove { get; set; }
    public abstract EntitySO EntityData { get; set; }
    #endregion

    #region methodes to herit
    public virtual void OnSpawn(Vector3 spawnPoint)
    {
        
    }
    public virtual void OnMove(float speed)
    {
        if (!CanMove) return;
    }
    public virtual void OnCollide(EntityEffectType type)
    {
        Debug.Log(":D");
    }
    #endregion
}
