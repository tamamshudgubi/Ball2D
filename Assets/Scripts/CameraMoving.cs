using UnityEngine;

public class CameraMoving : MonoBehaviour
{
    [SerializeField] private PlayerController _player;

    private float _speed;

    private void Awake()
    {
        _speed = _player.GetCurrentSpeed();
    }

    private void Update()
    {
        transform.Translate(new Vector2(_speed * Time.deltaTime, 0));
    }
}
