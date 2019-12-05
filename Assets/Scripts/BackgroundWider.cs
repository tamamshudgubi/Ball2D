using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundWider : MonoBehaviour
{
    public float CallDown;
    public float TimeToWide;
    public float CurrentSize;

    void Update()
    {
        TimeToWide += Time.deltaTime;
        if (TimeToWide >= 2f)
        {
            gameObject.GetComponent<SpriteRenderer>().size = new Vector2(CurrentSize + 42f, 15.36f);
            gameObject.transform.position = new Vector3(gameObject.transform.position.x + 23.4f, gameObject.transform.position.y);
            CurrentSize = gameObject.GetComponent<SpriteRenderer>().size.x;
            TimeToWide = CallDown;
        }

    }
}
