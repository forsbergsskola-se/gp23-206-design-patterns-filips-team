using System;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{
    [SerializeField] public GameObject projectilePrefab;

    public static ObjectPool instance;
    [SerializeField] private int poolSize = 1;

    [SerializeField] private List<GameObject> pooledObjects = new List<GameObject>();

private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    private void Start()
    {
        // Initialize the pool
        for (int i = 0; i < poolSize; i++)
        {
            GameObject obj = Instantiate(projectilePrefab);
            obj.SetActive(false);
            pooledObjects.Add(obj);
        }
    }

    public GameObject GetObjectFromPool()
    {
        for (int i = 0; i < pooledObjects.Count; i++)
        {
            if (!pooledObjects[i].activeInHierarchy)
            {
                return pooledObjects[i];
            }
        }

        return null;
    }
    public void ReturnObjectToPool(GameObject obj)
    {
        Debug.Log("object returned to pool in pool object");
        obj.SetActive(false);
    }
}