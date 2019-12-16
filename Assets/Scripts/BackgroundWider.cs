using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundWider : MonoBehaviour
{
    public bool IsWide;

    private float _currentSize;
    private float _fixedXSize = 42f;
    private float _fixedTransfomXsize = 23.4f;

    private SpriteRenderer Renderer;

    private void Update()
    {
        if (IsWide)
        {
            Wide();
        }

        IsWide = false;
    }

    public void Wide()
    {
        Renderer.size = new Vector2(_currentSize + _fixedXSize, Renderer.size.y);
        transform.position = new Vector3(transform.position.x + _fixedTransfomXsize, transform.position.y);
        _currentSize = Renderer.size.x;
    }
}
