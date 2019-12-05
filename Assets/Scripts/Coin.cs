using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public CoinData data; 
    public CoinData TakeCoin()
    {
        Destroy(gameObject);

        return data;
    }
}
