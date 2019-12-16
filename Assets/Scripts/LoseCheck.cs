using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoseCheck : MonoBehaviour
{
    private bool _isLose;

    public GameObject LoseMenu;

    public Transform Point;
    public float Angle;
    public GameObject Size;
    public LayerMask WhoIsPlayer;

    private void Update()
    {
        if (!IsPlayerInGame())
        {
            Time.timeScale = 0;
            LoseMenu.SetActive(!_isLose);
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
