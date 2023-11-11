using UnityEngine;
using UnityEngine.InputSystem;

public abstract class Unit : MonoBehaviour, IUnit
{
    #region accessors to herit
    public abstract InputActionReference Aim { get; set; }

    public abstract InputActionReference Shoot { get; set; }

    public abstract InputActionReference Drag { get; set; }

    public abstract bool IsLocked { get; set; }

    public abstract Entity Presselected { get; set; }

    public abstract UnitSO UnitData { get; set; }
    #endregion

    #region methodes to herit
    public virtual Vector3 OnAim()
    {
        return Vector3.zero;
    }

    public virtual void OnDrag(Vector3 targetPos)
    {
        
    }

    public virtual void OnRelease()
    {
        
    }

    public virtual void OnShoot()
    {
        if (IsLocked) return;

    }
    #endregion
}
