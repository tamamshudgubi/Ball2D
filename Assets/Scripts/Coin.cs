using UnityEngine;

public class Coin : MonoBehaviour
{
    private int _cost = 100;

    public int TakeCoin()
    {
        Destroy(gameObject);

        return _cost;
    }
}
