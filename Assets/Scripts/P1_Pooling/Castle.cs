using UnityEngine;
using System.Collections.Generic;
/*
public class Castle : MonoBehaviour
{
    private Transform _target;
    private int _enemyLayerMask;
    private float _currentCooldown;
    
    const float _maxCooldown = 0.8f;

    [SerializeField]private GameObject prefabObject;
    
    void Start()
    {
        this._enemyLayerMask = LayerMask.GetMask("Enemy");
    }

    // Update is called once per frame
    void Update()
    {
        AcquireTargetIfNecessary();
        TryAttack();
    }

    void AcquireTargetIfNecessary()
    {
        if (this._target == null)
        {
            this._target = Physics2D.OverlapCircle(this.transform.position, 5f, this._enemyLayerMask)?.transform;
        }
    }

    void TryAttack()
    {
        _currentCooldown -= Time.deltaTime;
        if (this._target == null || !(_currentCooldown <= 0f)) return;
        this._currentCooldown = _maxCooldown;
        Attack();
    }

    void Attack()
    {   //Why isnt projectiles coming from the pool?
        //Instantiate(this.Projectile, this.transform.position, GetTargetDirection());
       
       GameObject bullet = ObjectPool.instance.GetObjectFromPool();
       if (bullet !=null)
       {
           bullet.transform.position = this.transform.position;
           bullet.transform.rotation = GetTargetDirection();
           bullet.SetActive(true);
       }
       Debug.Log("Attack invoked");
    }
    Quaternion GetTargetDirection()
    {
        var dir = this._target.transform.position - this.transform.position;
        var angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg - 90f;
        return Quaternion.AngleAxis(angle, Vector3.forward);
    }
}
*/