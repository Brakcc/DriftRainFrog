using System.Collections;
using UnityEngine;

public class UnitSO : ScriptableObject, IUnitData
{
    public float Speed { get => speed; set { speed = value; } }
    [SerializeField] private float speed;

    public float Reach { get => reach; set { reach = value; } }
    [SerializeField] private float reach;

    public AudioClip AudioEff { get => audioEff; set { audioEff = value; } }
    [SerializeField] private AudioClip audioEff;
}