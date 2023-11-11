using UnityEngine;

public abstract class Unit : MonoBehaviour, IUnit
{
    #region accessors to herit

    public abstract bool IsLocked { get; set; }

    public abstract Entity Presselected { get; set; }

    public abstract Rigidbody2D Rb { get; set; }

    public abstract float Speed { get; set; }

    public abstract UnitSO UnitData { get; set; }
    #endregion

    #region methodes to herit
    public virtual void OnInit()
    {
        Rb = GetComponent<Rigidbody2D>();
        IsLocked = false;
    }

    public virtual void OnLimit() => Rb.velocity = new(Mathf.Clamp(Rb.velocity.x, -UnitData.MaxSpeed, UnitData.MaxSpeed), Mathf.Clamp(Rb.velocity.y, -UnitData.MaxSpeed, UnitData.MaxSpeed));

    public virtual Vector2 OnAim() => UnitData.Aim.action.ReadValue<Vector2>();

    public virtual void OnDrag(Vector2 targetPos)
    {
        if (!IsLocked) return;
        Rb.velocity = new Vector2();
        Debug.Log("Drag");
    }

    public virtual void OnRelease()
    {
        Presselected.CanMove = true;
        Presselected = null;
        IsLocked = false;
        Debug.Log("Realesed");
    }

    public virtual void OnShoot(Vector2 dir)
    {
        //if (IsLocked) return;
        RaycastHit2D aimAt = Physics2D.Raycast(transform.position, dir, UnitData.Reach, UnitData.ObjectLayer);
        Debug.Log("shoot");

        if (aimAt)
        {
            Debug.Log("Hit");
            Presselected = aimAt.transform.GetComponent<Entity>();
            Presselected.CanMove = false;
            IsLocked = true;
        }
    }
    #endregion
}
