using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinsSpawner : MonoBehaviour
{
    private float SpawnTimeLimit = 0.5f;
    private float MaxObstacleY = -2.5f;
    private float TImetoSpawn;
    private float CoolDown = 0.00f;

    private Rigidbody2D rb;
    public float Speed;

    public GameObject Coin;
    public GameObject CoinSpawn;

    public float Radius;
    public Transform Point;
    public LayerMask IsPlaceFree;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        TImetoSpawn += Time.deltaTime;

        rb.velocity = new Vector2(Speed, rb.velocity.y);

        if (TImetoSpawn >= SpawnTimeLimit)
        {
            if (CheckObstacleForward() == false)
            {
                SpawnCoinOnGround();
            }
            else
            {
                SpawnCoinAboveObstacle();
            }

            TImetoSpawn = CallDown;
        }

    }

    private void SpawnCoinOnGround()
    {
        Instantiate(Coin, transform.position, Quaternion.identity);
    }

    private void SpawnCoinAboveObstacle()
    {
        Instantiate(Coin, new Vector3(transform.position.x, -MaxObstacleY), Quaternion.identity);
    }

    private bool CheckObstacleForward()
    {
        if (Physics2D.OverlapCircle(Point.transform.position, Radius, IsPlaceFree))
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
