using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Player : MonoBehaviour
{
    private ObstacleCheker ObstacleCheker;
    private GroundCheker GroundCheker;
    private Rigidbody2D rb;

    public TMP_Text WalletDisplay;
    public float Speed;
    public float JumpForce;
    public int Wallet;

    private void Start()
    {
        Time.timeScale = 1;
        rb = GetComponent<Rigidbody2D>();
        GroundCheker = GetComponent<GroundCheker>();
        ObstacleCheker = GetComponent<ObstacleCheker>();
    }

    private void Update()
    {
        rb.velocity = new Vector2(Speed * Time.deltaTime, rb.velocity.y);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (GroundCheker.CheckGround() || ObstacleCheker.CheckObstacle())
            {
                rb.AddForce(Vector2.up * JumpForce, ForceMode2D.Impulse);
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
