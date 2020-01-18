using UnityEngine;

public class BackgroundExpander : MonoBehaviour
{
    [SerializeField] private SpriteRenderer _renderer;

    private float _fixedXSize = _renderer.size.x;

    public void Widen()
    {
        _renderer.size = new Vector2(_renderer.size.x + fixedXSize, _renderer.size.y);
    }
}
