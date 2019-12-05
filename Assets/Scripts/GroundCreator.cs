using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundCreator : MonoBehaviour
{
    public bool IsCreate;

    public GameObject StartPoint;
    public Transform RenderPoint;
    public GameObject WhatIsGround;
    public GameObject Trap;
    public int counter;

    private void Start()
    {
        StartPoint.GetComponent<IsOnThroughPoint>().Ground = gameObject;
        StartPoint.GetComponent<TrapsCreator>().Trap = Trap;
    }

    private void Update()
    {
        if (IsCreate)
        {
            CreateGround();
        }

        IsCreate = false;
    }

    public void CreateGround()
    {
        GameObject ground = Instantiate(StartPoint, new Vector3(counter, RenderPoint.transform.position.y, RenderPoint.transform.position.z), Quaternion.identity).GetComponent<GameObject>();
        counter += 15;
    }
}
