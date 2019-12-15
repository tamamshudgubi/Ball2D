using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundWider : MonoBehaviour
{
    public bool IsWide;

    public float CurrentSize;
    public float FixedXSize = 42f;
    public float FixedTransfomXsize = 23.4f;

    public SpriteRenderer Renderer;
    void Update()
    {
        if (IsWide)
        {
            Wide();
        }

        IsWide = false;
    }

    public void Wide()
    {
        Renderer.size = new Vector2(CurrentSize + FixedXSize, Renderer.size.y);
        transform.position = new Vector3(transform.position.x + FixedTransfomXsize, transform.position.y);
        CurrentSize = Renderer.size.x;
    }
}
