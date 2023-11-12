using UnityEngine;

public class Flies : AEntity
{
    #region inherited fields
    public override bool CanMove { get; set; }

    public override EntitySO EntityData { get => entityData; set { entityData = value; } }
    [SerializeField] EntitySO entityData;

    public override float ZoneSpeed { get; set; }
    #endregion

    #region inherited methodes
    void Start()
    {
        OnSpawn();
    }

    // Update is called once per frame
    void Update()
    {
        OnMove(EntityData.Speed + ZoneSpeed);
    }
    #endregion
}
