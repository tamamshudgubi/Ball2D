using UnityEngine;

public class Coin : MonoBehaviour
{
    public int Cost = 100;
    public int TakeCoin()
    {
        Destroy(gameObject);

        return Cost;
    }
}
