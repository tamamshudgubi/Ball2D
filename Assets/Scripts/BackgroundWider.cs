using UnityEngine;

public class BackgroundWider : MonoBehaviour
{
    [SerializeField] private SpriteRenderer _renderer;

    public void Widen()
    {
        float fixedXSize = 42f;
        float fixedTransfomXsize = 23.4f;

        _renderer.size = new Vector2(_renderer.size.x + fixedXSize, _renderer.size.y);
        transform.position = new Vector3(transform.position.x + fixedTransfomXsize, transform.position.y);
    }
}
