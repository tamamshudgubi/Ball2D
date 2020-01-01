using UnityEngine;

public class ObstacleCheker : MonoBehaviour
{
    public float Radius;
    public LayerMask WhatIsObstacle;
    public Transform Point;

    public bool CheckObstacle()
    {
        return Physics2D.OverlapCircle(Point.transform.position, Radius, WhatIsObstacle);
    }
}
