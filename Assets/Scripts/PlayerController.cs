using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Player : MonoBehaviour
{
    public GameObject TrapCheker;
    public GameObject GroundCheker;
    public TMP_Text WalletDisplay;
    public Rigidbody2D rb;

    public float Speed;
    public float JumpForce;
    public int Wallet;
    void Start()
    {
        Time.timeScale = 1;
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        rb.velocity = new Vector2(Speed * Time.deltaTime, rb.velocity.y);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (GroundCheker.GetComponent<GroundCheker>().CheckGround() || TrapCheker.GetComponent<ObstacleCheker>().CheckObstacle())
            {
                rb.AddForce(Vector2.up * JumpForce, ForceMode2D.Impulse);
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Coin coin = GetComponent<Coin>();

        if (coin != null)
        {
            collision.GetComponent<Coin>().TakeCoin();
            Wallet += collision.gameObject.GetComponent<Coin>().Cost;
            WalletDisplay.text = Wallet.ToString();
        }
    }
}
