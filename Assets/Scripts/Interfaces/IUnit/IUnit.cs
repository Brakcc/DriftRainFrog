using UnityEngine;

public interface IUnit
{
    #region accessors
    bool IsLocked { get; }
    AEntity Presselected { get; }
    Rigidbody2D Rb { get; }
    float Speed { get; }
    #endregion

    #region methodes
    Vector2 OnAim();
    void OnShoot(Vector2 dir);
    void OnDrag(Vector2 targetPos, Vector2 aim);
    void OnRelease();
    #endregion
}
