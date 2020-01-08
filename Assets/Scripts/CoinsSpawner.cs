using UnityEngine;

public class CoinsSpawner : MonoBehaviour
{
    [SerializeField] private PlayerController _player;

    [SerializeField] private float _timeToSpawn;
    [SerializeField] private float _distanceToSpawn = 10f;
    private float _spawnRate = 2;

    [SerializeField] private GameObject _coin;

    [SerializeField] private float _radius;
    [SerializeField] private Transform _point;
    [SerializeField] private LayerMask _isPlaceFree;

    private void Update()
    {
        _timeToSpawn += Time.deltaTime;

        if (_timeToSpawn >= _spawnRate)
        {
            if (CheckObstacleForward() == false)
            {
                SpawnCoinOnGround();
            }
            else
            {
                SpawnCoinAboveObstacle();
            }

            _timeToSpawn = 0;
        }
    }

    private void SpawnCoinOnGround()
    {
        Instantiate(_coin, new Vector3(_player.transform.position.x + _distanceToSpawn, gameObject.transform.position.y), Quaternion.identity);
    }

    private void SpawnCoinAboveObstacle()
    {
        float maxObstacleY = -2.5f;
        Instantiate(_coin, new Vector3(_player.transform.position.x + _distanceToSpawn, maxObstacleY), Quaternion.identity);
    }

    private bool CheckObstacleForward()
    {
        return Physics2D.OverlapCircle(_point.transform.position, _radius, _isPlaceFree);
    }
}
