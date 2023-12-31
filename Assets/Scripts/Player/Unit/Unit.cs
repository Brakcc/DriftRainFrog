using UnityEngine;

public abstract class Unit : MonoBehaviour, IUnit
{
    #region accessors to herit
    public abstract bool IsDead { get; set; }
    public abstract bool IsLocked { get; set; }
    public abstract AEntity Presselected { get; set; }
    public abstract Rigidbody2D Rb { get; set; }
    public abstract LineRenderer Lr { get; set; }
    public abstract float Speed { get; set; }
    public abstract Vector2 Tar { get; set; }
    public abstract float Temp { get; set; }
    public abstract UnitSO UnitData { get; set; }
    public abstract Animator Anim { get; set; }
    #endregion

    #region methodes to herit
    public virtual void OnInit()
    {
        Rb = GetComponent<Rigidbody2D>();
        Lr = GetComponent<LineRenderer>();
        Anim = GetComponent<Animator>();
        IsLocked = false;
    }

    public virtual void OnLimit() 
    {
        Rb.velocity = new(Mathf.Clamp(Rb.velocity.x, -UnitData.MaxSpeed, UnitData.MaxSpeed), Mathf.Clamp(Rb.velocity.y, -UnitData.MaxSpeed, UnitData.MaxSpeed));
    }

    public virtual Vector2 OnAim() => UnitData.Aim.action.ReadValue<Vector2>();

    public virtual void OnPreAim(Vector2 aimed)
    {
        if (IsLocked) return;
        Lr.enabled = true;
        Vector3[] aimedPos = new Vector3[] { transform.position, new Vector3(aimed.x, aimed.y, 0) + transform.position};
        Lr.SetPositions(aimedPos);
        Vector2 dir = aimed - new Vector2(transform.position.x, transform.position.y);
        float angle = Vector2.SignedAngle(Vector2.up, dir);
        transform.eulerAngles = new Vector3(0, 0, angle);
    }

    public virtual void OnDrag(Vector2 targetPos, Vector2 aim)
    {
        if (!IsLocked) return;
        if ((new Vector3(Tar.x, Tar.y, 0) - transform.position).magnitude > UnitData.Reach) OnRelease(OnAim());
        Rb.gravityScale = 0;
        GenerateTongue(targetPos);
        if (Speed < UnitData.MaxSpeed) { Speed += Time.deltaTime; }
        Rb.AddForce((targetPos - new Vector2(transform.position.x, transform.position.y)).normalized * Speed * 15);
        Rb.AddForce(aim.normalized * 50);
    }

    public virtual void OnReleaseForced()
    {
        if (Presselected != null) { Presselected.CanMove = true; Presselected = null; }
        Tar = transform.position;
        Rb.gravityScale = -1;
        Lr.enabled = false;
        Anim.SetTrigger("Release");
        IsLocked = false;
    }

    public virtual void OnRelease(Vector2 dir)
    {
        if (Presselected != null) { Presselected.CanMove = true; Presselected = null; }
        Tar = transform.position;
        Rb.gravityScale = -1;
        Rb.AddForce(dir.normalized * 40);
        Lr.enabled = false;
        Anim.SetTrigger("Release");
        IsLocked = false;
    }

    public virtual void OnShoot(Vector2 dir)
    {
        if (IsLocked) return;
        RaycastHit2D aimAt = Physics2D.Raycast(transform.position, dir, UnitData.Reach, UnitData.ObjectLayer);
        Anim.SetTrigger("Shoot");

        if (!aimAt) return;
        Presselected = aimAt.transform.GetComponent<AEntity>();
        
        if (Presselected.EntityData.TypeEntity == EntityType.Solid)
        {
            Presselected.CanMove = false;
            IsLocked = true;
            Tar = aimAt.point;
            Temp = (Tar - Rb.position).magnitude;
            AudioManager.ad.PlayClipAt(UnitData.AudioEff, aimAt.point);
            Rb.velocity /= new Vector2(2, 2);
        }
        else if (Presselected.EntityData.TypeEntity == EntityType.Collectible)
        {
            GameManager.gm.CurrentFlyNumber++;
            Destroy(Presselected.gameObject);
            Presselected = null;
        }
    }
    #endregion

    #region cache
    void GenerateTongue(Vector2 TP)
    {
        Vector3[] pos = new Vector3[2];
        pos[0] = TP;
        pos[1] = transform.position;
        Lr.enabled = true;
        Lr.SetPositions(pos);
    }
    #endregion
}
