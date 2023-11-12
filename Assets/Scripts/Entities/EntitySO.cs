using UnityEngine;
using CustomAttributes;

[CreateAssetMenu(fileName = "Entity", menuName = "Froggo/Entity")]
public class EntitySO : ScriptableObject, IEntity
{
    public int Id { get => id; private set { id = value; } }
    [SerializeField] int id;

    public float Speed { get => speed; private set { speed = value; } }
    [SerializeField] float speed;
    public EntityType TypeEntity { get => entityType; private set { entityType = value; } }
    [SerializeField] EntityType entityType;

    public EntityEffectType EffectType { get => effectType; private set { effectType = value; } }
    [SerializeField] EntityEffectType effectType;

    public float Power { get => power; private set { power = value; } }
    [ShowIfTrue("effectType", 1)][SerializeField] float power;

    public AudioClip AudioEff { get => audioEff; private set { audioEff = value; } }
    [SerializeField] AudioClip audioEff;
}