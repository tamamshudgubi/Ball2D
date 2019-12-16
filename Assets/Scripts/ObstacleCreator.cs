using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleCreator : MonoBehaviour
{
    [System.Serializable] private float FixedYPoz;
    private int ObstacleCount = 10;

    public GameObject Obstacle;

    private void Start()
    {
        for (int i = 0; i < ObstacleCount; i++)
        {
            float x = Random.Range(gameObject.transform.position.x, gameObject.transform.position.x * 2);
            GameObject obstacle = Instantiate(Obstacle, new Vector3(x, FixedYPoz), Quaternion.identity).GetComponent<GameObject>();
        }
    }
}
