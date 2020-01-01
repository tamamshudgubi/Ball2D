using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerController : MonoBehaviour
{
    public GameObject TrapCheker;
    public GameObject GroundCheker;
    private Rigidbody2D _rb;

    public float Speed;
    public float JumpForce;
    public int Wallet;

    public UnityEvent TakeEvent;

    private void Start()
    {
        Time.timeScale = 1;
        _rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        _rb.velocity = new Vector2(Speed * Time.deltaTime, _rb.velocity.y);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (GroundCheker.GetComponent<GroundCheker>().CheckGround() || TrapCheker.GetComponent<ObstacleCheker>().CheckObstacle())
            {
                _rb.AddForce(Vector2.up * JumpForce, ForceMode2D.Impulse);
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Coin coin = GetComponent<Coin>();

        if (coin != null)
        {
            Wallet += coin.Cost;
            TakeEvent.Invoke();
        }
    }
}
