using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class EnemySpawner : MonoBehaviour
{
    private const float _totalCooldown = 2f;
    private float _currentCooldown;
    public GameObject objectPrefab;
    public int poolSize = 10;

    [SerializeField] private List<GameObject> pooledObjects = new List<GameObject>();
    
    private void Start()
    {
        // Initialize the pool
        for (int i = 0; i < poolSize; i++)
        {
            GameObject obj = Instantiate(objectPrefab);
            obj.SetActive(false);
            pooledObjects.Add(obj);
        }
    }
    
    
    // Update is called once per frame
    void FixedUpdate()
    {
        this._currentCooldown -= Time.deltaTime;
        if (this._currentCooldown <= 0f)
        {
            this._currentCooldown += _totalCooldown;
            SpawnEnemies();
        }
    }
    
    void SpawnEnemies()
    {
        var maxAmount = Mathf.CeilToInt(Time.timeSinceLevelLoad / 7);
        int amount = Random.Range(maxAmount, maxAmount + 3);
        for (var i = 0; i < amount; i++)
        {
            Debug.Log("spawned");
            GetObjectFromPool();
        }
    }
    public  GameObject GetObjectFromPool()
    {
        // Find an available object in the pool
        foreach (GameObject obj in pooledObjects)
        {
            if (!obj.activeInHierarchy)
            {
                obj.SetActive(true);
                return obj;
            }
        }

        // If all objects are in use, expand the pool by instantiating a new object
        GameObject newObj = Instantiate(objectPrefab);
        pooledObjects.Add(newObj);
        return newObj;
    }

    public void ReturnObjectToPool(GameObject obj)
    {
        // Deactivate and reset the object before returning it to the pool
        obj.SetActive(false);
        _currentCooldown = 0.0f;
        obj.transform.position = Vector3.zero; // Reset position (optional)
        obj.transform.rotation = Quaternion.identity; // Reset rotation (optional)
    }
   
}
