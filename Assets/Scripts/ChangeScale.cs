using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeScale : MonoBehaviour
{
    public float TrapwidthMin;
    public float TrapheightMin;
    public float TrapwidthMax;
    public float TrapheightMax;
    void Start()
    {
        gameObject.transform.localScale = new Vector3(Random.Range(TrapwidthMin, TrapwidthMax), Random.Range(TrapheightMin, TrapheightMax), 1);
    }

}
