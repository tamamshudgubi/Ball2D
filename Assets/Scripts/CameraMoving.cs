using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class CameraMoving : MonoBehaviour
{
    public float Speed;

    private Rigidbody2D _rb;

    private void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        _rb.velocity = new Vector2(Speed, _rb.velocity.y);
    }
}
