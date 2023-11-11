using UnityEngine;

[CreateAssetMenu(fileName = "Entity", menuName = "Froggo/Entity")]
public class EntitySO : ScriptableObject, IEntity
{
    public int Id { get => id; set { id = value; } }
    [SerializeField] int id;

    public float Speed { get => speed; set { speed = value; } }
    [SerializeField] float speed;

    public float Power { get => power; set { power = value; } }
    [SerializeField] float power;

    public EntityEffectType EffectType { get => effectType; set { effectType = value; } }
    [SerializeField] EntityEffectType effectType;

    public AudioClip AudioEff { get => audioEff; set { audioEff = value; } }
    [SerializeField] AudioClip audioEff;
}