using System;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerController : MonoBehaviour
{
    [SerializeField] private ObstacleChecker _obstacleChecker;
    [SerializeField] private GroundChecker _groundChecker;

    [SerializeField] private float _speed;
    [SerializeField] private float _jumpForce;

    private int _wallet;

    private Rigidbody2D _rigidbody;

    public event Action<int> CoinCollected;

    private void Start()
    {
        Time.timeScale = 1;
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        _rigidbody.velocity = new Vector2(_speed * Time.deltaTime, _rigidbody.velocity.y);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (_groundChecker.CheckGround() || _obstacleChecker.CheckObstacle())
            {
                _rigidbody.AddForce(Vector2.up * _jumpForce, ForceMode2D.Impulse);
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Coin coin = collision.GetComponent<Coin>();

        if (coin)
        {
            _wallet += coin.TakeCoin();
            CoinCollected?.Invoke(_wallet);
        }
    }

    public float GetCurrentSpeed()
    {
        return _speed;
    }
}
