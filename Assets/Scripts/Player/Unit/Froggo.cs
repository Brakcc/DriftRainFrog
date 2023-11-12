using UnityEngine;
using UnityEngine.InputSystem;

public class Froggo : Unit
{
    #region inherited
    public override bool IsDead { get; set; }
    public override bool IsLocked { get; set; }
    public override AEntity Presselected { get; set; }
    public override Rigidbody2D Rb { get; set; }
    public override LineRenderer Lr { get; set; }
    public override float Speed { get; set; }
    public override Vector2 Tar { get; set; }
    public override float Temp { get; set; }
    public override UnitSO UnitData { get => unitData; set { unitData = value; } }
    [SerializeField] UnitSO unitData; 
    #endregion

    #region inherited methodes
    void Start()
    {
        OnInit();
    }

    // Update is called once per frame
    void Update()
    {
        if (IsDead) return;
        OnLimit();
        OnPreAim(OnAim());
        if (UnitData.Shoot.action.WasPressedThisFrame()) { OnShoot(OnAim()); }
        OnDrag(Tar, OnAim());
        if (UnitData.Shoot.action.WasReleasedThisFrame()) { OnRelease(OnAim()); }
    }
    #endregion
}
