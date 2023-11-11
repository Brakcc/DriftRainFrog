using UnityEngine;

public interface IUnit
{
    #region accessors
    bool IsLocked { get; }

    Entity Presselected { get; }
    #endregion

    #region methodes
    Vector3 OnAim();
    void OnShoot();
    void OnDrag(Vector3 targetPos);
    void OnRelease();
    #endregion
}
