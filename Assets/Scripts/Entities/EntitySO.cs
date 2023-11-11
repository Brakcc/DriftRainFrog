using UnityEngine;

public class EntitySO : ScriptableObject, IEntity
{
    public int Id { get => id; set { id = value; } }
    [SerializeField] int id;

    public int Importance { get => importance; set { importance = value; } }
    [SerializeField] int importance;

    public float Speed { get => speed; set { speed = value; } }
    [SerializeField] float speed;

    public EntityEffectType EffectType { get => effectType; set { effectType = value; } }
    [SerializeField] EntityEffectType effectType;

    public AudioClip AudioEff { get => audioEff; set { audioEff = value; } }
    [SerializeField] AudioClip audioEff;
}