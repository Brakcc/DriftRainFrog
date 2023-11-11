using UnityEngine;
using UnityEngine.InputSystem;

public interface IUnitData
{
    InputActionReference Aim { get; }
    InputActionReference Shoot { get; }
    LayerMask ObjectLayer { get; }
    float MaxSpeed { get; }
    float Reach { get; }
    AudioClip AudioEff { get; }
}
