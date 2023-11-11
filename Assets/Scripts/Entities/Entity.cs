using UnityEngine;

public abstract class Entity : MonoBehaviour
{
    #region accessors to herit
    public abstract EntitySO EntityData { get; set; }
    #endregion

    #region methodes to herit
    public virtual void OnSpawn(Vector3 spawnPoint)
    {
        
    }
    public virtual void OnMove(float speed)
    {

    }
    public virtual void OnCollide(EntityEffectType type)
    {
        Debug.Log(":D");
    }
    #endregion
}
