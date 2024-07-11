using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.Windows;
using Random = UnityEngine.Random;

public class TreeSpawner : MonoBehaviour
{
    public TreeV2 treePrefab;
    private float _currentCooldown;
    
    const float _totalCooldown = 0.2f;
    
    void FixedUpdate()
    {
        this._currentCooldown -= Time.deltaTime;
        if (this._currentCooldown <= 0f)
        {
            this._currentCooldown += _totalCooldown;
            SpawnTree();
        }
    }

    void SpawnTree()
    {
        var randomPositionX = Random.Range(-6f, 6f);
        var randomPositionY = Random.Range(-6f, 6f);
        Instantiate(this.treePrefab, new Vector2(randomPositionX, randomPositionY), Quaternion.identity);
    }
}
