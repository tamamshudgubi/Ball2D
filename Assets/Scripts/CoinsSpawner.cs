using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinsSpawner : MonoBehaviour
{
    public float MaxObstacleY = -2.5f;
    public float TImetoSpawn;
    public float CallDown;

    public Rigidbody2D rb;
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

        if (TImetoSpawn >= 0.5f)
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

    public void SpawnCoinOnGround()
    {
        Instantiate(Coin, gameObject.transform.position, Quaternion.identity);
    }

    public void SpawnCoinAboveObstacle()
    {
        Instantiate(Coin, new Vector3(gameObject.transform.position.x, -MaxObstacleY), Quaternion.identity);
    }

    public bool CheckObstacleForward()
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
