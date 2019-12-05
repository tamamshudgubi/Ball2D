using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IsOnThroughPoint : MonoBehaviour
{
    public GameObject Ground;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Ground.GetComponent<GroundCreator>().IsCreate = true;
        }
    }


}
