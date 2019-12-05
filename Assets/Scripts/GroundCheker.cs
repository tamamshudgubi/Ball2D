using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundCheker : MonoBehaviour
{
    public Transform Point;
    public LayerMask WhatIsGround;
    public float Radius;
    public bool CheckGround()
    {
        if (Physics2D.OverlapCircle(Point.transform.position, Radius, WhatIsGround))
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
