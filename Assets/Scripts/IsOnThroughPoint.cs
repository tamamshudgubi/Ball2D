using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IsOnThroughPoint : MonoBehaviour
{
    public GameObject groundcreator;
    public GameObject BGWider;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Player player = collision.GetComponent<Player>();

        if (player != null)
        {
            groundcreator.GetComponent<GroundCreator>().IsCreate = true;
            BGWider.GetComponent<BackgroundWider>().IsWide = true;
        }
    }


}
