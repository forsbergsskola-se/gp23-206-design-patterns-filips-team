using UnityEngine;
using Random = UnityEngine.Random;

public class TreeSpawner : MonoBehaviour
{
    public Tree treePrefab; 
    private float _currentCooldown;
    const float _totalCooldown = 0.2f;
    
    void FixedUpdate()
    {
        _currentCooldown -= Time.deltaTime;
        if (_currentCooldown <= 0f)
        {
            _currentCooldown += _totalCooldown;
            SpawnTree();
        }
    }

    void SpawnTree()
    {
        float randomPositionX = Random.Range(-6f, 6f);
        float randomPositionY = Random.Range(-6f, 6f);
        Instantiate(treePrefab, new Vector2(randomPositionX, randomPositionY), Quaternion.identity);
    }
}