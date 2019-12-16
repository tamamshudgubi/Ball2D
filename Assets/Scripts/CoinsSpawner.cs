using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinsSpawner : MonoBehaviour
{
    private float _spawnTimeLimit = 0.5f;
    private float _maxObstacleY = -2.5f;
    private float _timetoSpawn;
    private float _coolDown = 0.00f;

    private Rigidbody2D _rb;
    public float Speed = 3f;

    public GameObject Coin;
    public GameObject CoinSpawn;

    public float Radius;
    public Transform Point;
    public LayerMask IsPlaceFree;

    private void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        _timetoSpawn += Time.deltaTime;

        _rb.velocity = new Vector2(Speed, _rb.velocity.y);

        if (_timetoSpawn >= _spawnTimeLimit)
        {
            if (CheckObstacleForward() == false)
            {
                SpawnCoinOnGround();
            }
            else
            {
                SpawnCoinAboveObstacle();
            }

            _timetoSpawn = _coolDown;
        }

    }

    private void SpawnCoinOnGround()
    {
        Instantiate(Coin, transform.position, Quaternion.identity);
    }

    private void SpawnCoinAboveObstacle()
    {
        Instantiate(Coin, new Vector3(transform.position.x, _maxObstacleY), Quaternion.identity);
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
