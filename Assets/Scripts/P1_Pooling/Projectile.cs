using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
/*
public class Projectile : MonoBehaviour
{
    private float _totalTime;
    public ObjectPool _objectPool;
   void Start()
    {
        _objectPool = ObjectPool.instance;
        FakeInitializeProjectile();
    }

    /// <summary>
    /// Setting up complex Prefabs containing Models, Sprites, Materials etc.
    /// Is Expensive. This Call simulates a more complex Object.
    /// Do not remove this Method invocation from Start.
    /// Instead, try to avoid `Start` being invoked in the first place. 
    /// </summary>
    void FakeInitializeProjectile()
    {
        Thread.Sleep(100);
    }
    
    // Update is called once per frame
    void Update()
    {
        this._totalTime += Time.deltaTime;
        this.transform.Translate(Vector3.up * Time.deltaTime);
        if (this._totalTime > 10f)
        {
            //Why destroy?
            //Destroy(this.gameObject);
            ReturnToPool();
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
         Debug.Log("OnCollisionEnter2D invoked");
         ReturnToPool();

    }

    private void ReturnToPool()
    { 
        _totalTime = 0;
        _objectPool.ReturnObjectToPool(this.gameObject);
    }
}
*/