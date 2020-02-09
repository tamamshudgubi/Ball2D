using UnityEngine;

public class ObstacleCheker : MonoBehaviour
{
    [SerializeField] private float _radius;
    [SerializeField] private LayerMask _whatIsObstacle;
    [SerializeField] private Transform _point;

    public bool CheckObstacle()
    {
        return Physics2D.OverlapCircle(_point.transform.position, _radius, _whatIsObstacle);
    }
}
