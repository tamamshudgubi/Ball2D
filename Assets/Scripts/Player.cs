using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Player : MonoBehaviour
{
    public GameObject TrapCheker;
    public GameObject GroundCheker;
    public bool IsPaused;
    public GameObject PauseMenu;
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
            if (GroundCheker.GetComponent<GroundCheker>().CheckGround() || TrapCheker.GetComponent<TrapsCheker>().CheckTrap())
            {
                rb.AddForce(Vector2.up * JumpForce, ForceMode2D.Impulse);
            }
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            PauseMenu.SetActive(!IsPaused);
            IsPaused = !IsPaused;

            if (Time.timeScale == 0.00f)
            {
                Time.timeScale = 1.0f;
            }
            else
            {
                Time.timeScale = 0.00f;
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Coin"))
        {
            collision.GetComponent<Coin>().TakeCoin();
            Wallet += collision.gameObject.GetComponent<Coin>().data.CoinCost;
            WalletDisplay.text = Wallet.ToString();
        }
    }
}
