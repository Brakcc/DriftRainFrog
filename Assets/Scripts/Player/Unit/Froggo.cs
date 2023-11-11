using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Froggo : Unit
{
    public override InputActionReference Aim { get => aim; set { aim = value; } }
    [SerializeField] InputActionReference aim;

    public override InputActionReference Shoot { get => shoot; set { shoot = value; } }
    [SerializeField] InputActionReference shoot;

    public override InputActionReference Drag { get => drag; set { drag = value; } }
    [SerializeField] InputActionReference drag;
 
    public override bool IsLocked { get; set; }

    public override Entity Presselected { get; set; }

    public override UnitSO UnitData { get => unitData; set { unitData = value; } }
    [SerializeField] UnitSO unitData;

    // Start is called before the first frame update
    void Start()
    {
        IsLocked = false;
    }

    // Update is called once per frame
    void Update()
    {
        OnAim();
        OnShoot();
    }
}
