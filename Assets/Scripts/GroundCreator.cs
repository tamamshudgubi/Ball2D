using UnityEngine;

public class GroundCreator : MonoBehaviour
{
    public GameObject StartPoint;
    public GameObject WhatIsGround;
    public GameObject Obstacle;
    public GameObject BG;
    public Transform RenderPoint;

    [SerializeField] private int _counter;

    private void Start()
    {
        StartPoint.GetComponent<IsOnThroughPoint>().Groundcreator = gameObject;
        StartPoint.GetComponent<IsOnThroughPoint>().BGWider = BG;
        StartPoint.GetComponent<ObstacleCreator>().Obstacle = Obstacle;
    }

    public void CreateGround()
    {
        GameObject ground = Instantiate(StartPoint, new Vector3(_counter, RenderPoint.transform.position.y, RenderPoint.transform.position.z), Quaternion.identity).GetComponent<GameObject>();

        _counter += _counter;
    }
}
