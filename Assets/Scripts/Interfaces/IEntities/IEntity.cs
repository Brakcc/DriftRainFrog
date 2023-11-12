using UnityEngine;

public interface IEntity
{
    int Id { get; }
    float Speed { get; }
    EntityType TypeEntity { get; }
    float Power { get; }
    EntityEffectType EffectType { get; }
    AudioClip AudioEff { get; }
}

public enum EntityEffectType
{
    Standard,
    BigBump,
    Repulse,
    None
}

public enum EntityType
{
    Solid,
    Collectible
}