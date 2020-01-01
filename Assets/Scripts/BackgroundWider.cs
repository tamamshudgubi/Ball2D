using UnityEngine;

public class BackgroundWider : MonoBehaviour
{
    public SpriteRenderer Renderer;

    public void Wide()
    {
        float FixedXSize = 42f;
        float FixedTransfomXsize = 23.4f;

        Renderer.size = new Vector2(Renderer.size.x + FixedXSize, Renderer.size.y);
        transform.position = new Vector3(transform.position.x + FixedTransfomXsize, transform.position.y);
    }
}
