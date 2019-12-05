using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapsCreator : MonoBehaviour
{
    public float FixedYPoz;
    public int TrapCount;

    public GameObject Trap;

    private void Start()
    {
        for (int i = 0; i < TrapCount; i++)
        {
            float x = Random.Range(gameObject.transform.position.x, gameObject.transform.position.x * 2);
            GameObject trap = Instantiate(Trap, new Vector3(x, FixedYPoz), Quaternion.identity).GetComponent<GameObject>();
        }
    }
}
