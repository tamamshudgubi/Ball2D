using UnityEngine;

public class ObstacleCreator : MonoBehaviour
{
    [SerializeField] private float _obstaclewidthMin;
    [SerializeField] private float _obstacleheightMin;
    [SerializeField] private float _obstaclewidthMax;
    [SerializeField] private float _obstacleheightMax;

    [SerializeField] private float _fixedYPoz;
    [SerializeField] private int _obstacleCount;

    [SerializeField] private GameObject _obstacle;

    private void Start()
    {
        for (int i = 0; i < _obstacleCount; i++)
        {
            float x = Random.Range(gameObject.transform.position.x, gameObject.transform.position.x * 2);

            GameObject obstacle = Instantiate(_obstacle, new Vector3(x, _fixedYPoz), Quaternion.identity);
            RandomScale(obstacle);
        }
    }

    private void RandomScale(GameObject newObstacle)
    {
        newObstacle.transform.localScale = new Vector3(Random.Range(_obstaclewidthMin, _obstaclewidthMax), Random.Range(_obstacleheightMin, _obstacleheightMax), 1);
    }
}
