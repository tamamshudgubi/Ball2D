using UnityEngine;

public class Coin : MonoBehaviour
{
    private int _cost = 100;

    public int PickUpCoin()
    {
        Destroy(gameObject);

        return _cost;
    }
}
