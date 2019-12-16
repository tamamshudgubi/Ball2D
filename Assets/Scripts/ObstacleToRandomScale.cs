using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleToRandomScale : MonoBehaviour
{
    [System.Serializable] private float _obstaclewidthMin;
    [System.Serializable] private float _obstacleheightMin;
    [System.Serializable] private float _obstaclewidthMax;
    [System.Serializable] private float _obstacleheightMax;

    private void Start()
    {
        gameObject.transform.localScale = new Vector3(Random.Range(_obstaclewidthMin, _obstaclewidthMax), Random.Range(_obstacleheightMin, _obstacleheightMax), 1);
    }

}
