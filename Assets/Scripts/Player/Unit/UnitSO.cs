using UnityEngine;
using UnityEngine.InputSystem;

[CreateAssetMenu(fileName = "Frog", menuName = "Froggo/Frog")]
public class UnitSO : ScriptableObject, IUnitData
{
    public InputActionReference Aim { get => aim; set { aim = value; } }
    [SerializeField] InputActionReference aim;

    public InputActionReference Shoot { get => shoot; set { shoot = value; } }
    [SerializeField] InputActionReference shoot;

    public LayerMask ObjectLayer { get => objectLayer; set { objectLayer = value; } }
    [SerializeField] LayerMask objectLayer;

    public float MaxSpeed { get => maxSpeed; set { maxSpeed = value; } }
    [SerializeField] private float maxSpeed;

    public float Reach { get => reach; set { reach = value; } }
    [SerializeField] private float reach;

    public AudioClip AudioEff { get => audioEff; set { audioEff = value; } }
    [SerializeField] private AudioClip audioEff;
}