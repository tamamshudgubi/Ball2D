using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckForPause : MonoBehaviour
{
    public GameObject PauseMenu;
    private bool _isPaused;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            PauseMenu.SetActive(!_isPaused);
            _isPaused = !_isPaused;

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
