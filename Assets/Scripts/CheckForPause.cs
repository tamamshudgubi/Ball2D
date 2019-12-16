using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckForPause : MonoBehaviour
{
    public GameObject PauseMenu;
    private bool IsPaused;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            PauseMenu.SetActive(!IsPaused);
            IsPaused = !IsPaused;

            if (Time.timeScale == 0.00f)
            {
                Time.timeScale = 1.0f;
            }
            else
            {
                Time.timeScale = 0.00f;
            }
        }
    }
}
