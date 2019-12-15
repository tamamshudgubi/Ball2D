using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleToRandomScale : MonoBehaviour
{
    public float ObstaclewidthMin;
    public float ObstacleheightMin;
    public float ObstaclewidthMax;
    public float ObstacleheightMax;
    void Start()
    {
        gameObject.transform.localScale = new Vector3(Random.Range(ObstaclewidthMin, ObstaclewidthMax), Random.Range(ObstacleheightMin, ObstacleheightMax), 1);
    }

}
