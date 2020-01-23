using System;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerController : MonoBehaviour
{
    [SerializeField] private ObstacleCheker _obstacleCheker;
    [SerializeField] private GroundCheker _groundCheker;

    [SerializeField] private float _speed;
    [SerializeField] private float _jumpForce;

    [SerializeField] private int _wallet;

    private Rigidbody2D _rigidbody;

    public event Action<int> GetCurrentCoinAmount;

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
            if (_groundCheker.CheckGround() || _obstacleCheker.CheckObstacle())
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
            GetCurrentCoinAmount?.Invoke(_wallet);
        }
    }
}
