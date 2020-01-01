using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class CoinsSpawner : MonoBehaviour
{
    [SerializeField] private float _timetoSpawn;
    [SerializeField] private float _callDown;

    private Rigidbody2D _rb;
    public float Speed;

    public GameObject Coin;

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

        if (_timetoSpawn >= 0.5f)
        {
            if (CheckObstacleForward() == false)
            {
                SpawnCoinOnGround();
            }
            else
            {
                SpawnCoinAboveObstacle();
            }

            _timetoSpawn = _callDown;
        }
    }

    private void SpawnCoinOnGround()
    {
        Instantiate(Coin, gameObject.transform.position, Quaternion.identity);
    }

    private void SpawnCoinAboveObstacle()
    {
        float MaxObstacleY = -2.5f;
        Instantiate(Coin, new Vector3(gameObject.transform.position.x, MaxObstacleY), Quaternion.identity);
    }

    private bool CheckObstacleForward()
    {
        return Physics2D.OverlapCircle(Point.transform.position, Radius, IsPlaceFree);
    }
}
