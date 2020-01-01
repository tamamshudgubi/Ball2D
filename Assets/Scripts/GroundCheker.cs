using UnityEngine;

public class GroundCheker : MonoBehaviour
{
    public Transform Point;
    public LayerMask WhatIsGround;
    public float Radius;

    public bool CheckGround()
    {
        return Physics2D.OverlapCircle(Point.transform.position, Radius, WhatIsGround);
    }
}
