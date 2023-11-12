using UnityEngine;

public interface IUnit
{
    #region accessors
    bool IsDead { get; }
    bool IsLocked { get; }
    AEntity Presselected { get; }
    Rigidbody2D Rb { get; }
    float Speed { get; }
    #endregion

    #region methodes
    void OnLimit();
    Vector2 OnAim();
    void OnPreAim(Vector2 aimed);
    void OnShoot(Vector2 dir);
    void OnDrag(Vector2 targetPos, Vector2 aim);
    void OnRelease(Vector2 dir);
    void OnReleaseForced();
    #endregion
}
