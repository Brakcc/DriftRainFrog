using UnityEngine;

public interface IEntity
{
    int Id { get; }
    int Importance { get; }
    float Speed { get; }
    EntityEffectType EffectType { get; }
    AudioClip AudioEff { get; }
}

public enum EntityEffectType
{
    Standard,
    BigBump,
    Repulse,
    Default
}