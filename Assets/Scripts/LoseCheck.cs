using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoseCheck : MonoBehaviour
{
    public bool IsLose;
    public GameObject LoseMenu;
    public Transform Point;
    public float Angle;
    public GameObject Size;
    public LayerMask WhoIsPlayer;

    void Update()
    {
        if (!IsPlayerInGame())
        {
            Time.timeScale = 0;
            LoseMenu.SetActive(!IsLose);
        }
    }
    public bool IsPlayerInGame()
    {
        if (Physics2D.OverlapBox(Point.transform.position, Size.GetComponent<BoxCollider2D>().size, Angle, WhoIsPlayer))
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
