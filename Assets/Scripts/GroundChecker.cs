using UnityEngine;

public class GroundCheker : MonoBehaviour
{
    [SerializeField] private Transform _point;
    [SerializeField] private LayerMask _whatIsGround;
    [SerializeField] private float _radius;

    public bool CheckGround()
    {
        return Physics2D.OverlapCircle(_point.transform.position, _radius, _whatIsGround);
    }
}
