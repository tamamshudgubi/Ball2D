using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleToRandomScale : MonoBehaviour
{
    [System.Serializable] private float ObstaclewidthMin;
    [System.Serializable] private float ObstacleheightMin;
    [System.Serializable] private float ObstaclewidthMax;
    [System.Serializable] private float ObstacleheightMax;

    private void Start()
    {
        gameObject.transform.localScale = new Vector3(Random.Range(ObstaclewidthMin, ObstaclewidthMax), Random.Range(ObstacleheightMin, ObstacleheightMax), 1);
    }

}
