using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapsCheker : MonoBehaviour
{
    public float RadiusTraps;
    public LayerMask WhatIsTrap;
    public Transform PointTraps;

    public bool CheckTrap()
    {
        if (Physics2D.OverlapCircle(PointTraps.transform.position, RadiusTraps, WhatIsTrap))
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
