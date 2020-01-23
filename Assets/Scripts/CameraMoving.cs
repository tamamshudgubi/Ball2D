using UnityEngine;

public class CameraMoving : MonoBehaviour
{
    [SerializeField] private float _speed;

    private void Update()
    {
        gameObject.transform.Translate(new Vector2(_speed * Time.deltaTime, 0));
    }
}
