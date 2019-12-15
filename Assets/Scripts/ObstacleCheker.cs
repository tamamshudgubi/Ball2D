using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleCheker : MonoBehaviour
{
    public float Radius;
    public LayerMask WhatIsObstacle;
    public Transform Point;

    public bool CheckObstacle()
    {
        if (Physics2D.OverlapCircle(Point.transform.position, Radius, WhatIsObstacle))
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
