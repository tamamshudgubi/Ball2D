using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleCreator : MonoBehaviour
{
    [System.Serializable] private float _fixedYPoz;
    private int _obstacleCount = 10;

    public GameObject Obstacle;

    private void Start()
    {
        for (int i = 0; i < _obstacleCount; i++)
        {
            float x = Random.Range(transform.position.x, transform.position.x * 2);
            GameObject obstacle = Instantiate(Obstacle, new Vector3(x, _fixedYPoz), Quaternion.identity).GetComponent<GameObject>();
        }
    }
}
