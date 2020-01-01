using UnityEngine;

public class ObstacleCreator : MonoBehaviour
{
    [SerializeField] private float _obstaclewidthMin;
    [SerializeField] private float _obstacleheightMin;
    [SerializeField] private float _obstaclewidthMax;
    [SerializeField] private float _obstacleheightMax;

    public float FixedYPoz;
    [SerializeField] private int _obstacleCount;

    public GameObject Obstacle;

    private void Start()
    {
        for (int i = 0; i < _obstacleCount; i++)
        {
            float x = Random.Range(gameObject.transform.position.x, gameObject.transform.position.x * 2);

            GameObject obstacle = Instantiate(Obstacle, new Vector3(x, FixedYPoz), Quaternion.identity).GetComponent<GameObject>();
            obstacle.transform.localScale = gameObject.transform.localScale = new Vector3(Random.Range(_obstaclewidthMin, _obstaclewidthMax), Random.Range(_obstacleheightMin, _obstacleheightMax), 1);
        }
    }
}
