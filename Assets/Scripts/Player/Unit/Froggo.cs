using UnityEngine;
using UnityEngine.InputSystem;

public class Froggo : Unit
{
    public override bool IsLocked { get; set; }

    public override Entity Presselected { get; set; }

    public override Rigidbody2D Rb { get; set; }

    public override float Speed { get; set; }

    public override UnitSO UnitData { get => unitData; set { unitData = value; } }
    [SerializeField] UnitSO unitData;

    [SerializeField] InputActionReference move;
    [SerializeField] InputActionReference hsoot;

    // Start is called before the first frame update
    void Start()
    {
        OnInit();
    }

    // Update is called once per frame
    void Update()
    {
        OnLimit();
        if (Keyboard.current.spaceKey.wasPressedThisFrame) { Debug.Log("eovnefkn"); OnShoot(move.action.ReadValue<Vector2>()); }
        OnDrag(move.action.ReadValue<Vector2>());
        if (Keyboard.current.spaceKey.wasReleasedThisFrame) { OnRelease(); }
    }
}
