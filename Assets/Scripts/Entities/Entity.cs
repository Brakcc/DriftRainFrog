using UnityEngine;

public class Entity : AEntity
{
    #region inherited accessors
    public override bool CanMove { get; set; }

    public override EntitySO EntityData { get => entityData; set { entityData = value; } }
    [SerializeField] EntitySO entityData;
    #endregion

    #region inherited methodes
    // Start is called before the first frame update
    void Start()
    {
        OnSpawn();
    }

    // Update is called once per frame
    void Update()
    {
        OnMove(EntityData.Speed);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player")) { OnCollide(EntityData.EffectType, collision.rigidbody); }
        if (collision.gameObject.CompareTag("Dest")) { Debug.Log("test"); Destroy(gameObject); }
    }
    #endregion
}
