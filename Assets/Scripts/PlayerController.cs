using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Player : MonoBehaviour
{
    private ObstacleCheker _obstacleCheker;
    private GroundCheker _groundCheker;
    private Rigidbody2D _rb;

    public TMP_Text WalletDisplay;
    public float Speed;
    public float JumpForce;
    public int Wallet;

    private void Start()
    {
        Time.timeScale = 1;
        _rb = GetComponent<Rigidbody2D>();
        _groundCheker = GetComponent<GroundCheker>();
        _obstacleCheker = GetComponent<ObstacleCheker>();
    }

    private void Update()
    {
        _rb.velocity = new Vector2(Speed * Time.deltaTime, _rb.velocity.y);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (_groundCheker.CheckGround() || _obstacleCheker.CheckObstacle())
            {
                _rb.AddForce(Vector2.up * JumpForce, ForceMode2D.Impulse);
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Coin coin = collision.GetComponent<Coin>();

        if (coin != null)
        {
            collision.GetComponent<Coin>().TakeCoin();
            Wallet += collision.gameObject.GetComponent<Coin>().Cost;
            WalletDisplay.text = Wallet.ToString();
        }
    }
}
