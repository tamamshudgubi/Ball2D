using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundCreator : MonoBehaviour
{
    public bool IsCreate;

    public GameObject StartPoint;
    public Transform RenderPoint;
    public GameObject WhatIsGround;
    public GameObject Obstacle;
    public GameObject BG;

    private int _counter = 10;

    private void Start()
    {
        StartPoint.GetComponent<IsOnThroughPoint>().groundcreator = gameObject;
        StartPoint.GetComponent<IsOnThroughPoint>().BGWider = BG;
        StartPoint.GetComponent<ObstacleCreator>().Obstacle = Obstacle;
    }

    private void Update()
    {
        if (IsCreate)
        {
            CreateGround();
        }

        IsCreate = false;
    }

    private void CreateGround()
    {
        GameObject ground = Instantiate(StartPoint, new Vector3(_counter, RenderPoint.transform.position.y, RenderPoint.transform.position.z), Quaternion.identity).GetComponent<GameObject>();
        _counter += _counter;
    }
}
