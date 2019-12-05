using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public Animator AuthorsAnim;


    private void Start()
    {
        Time.timeScale = 1;
    }
    public void Play()
    {
        SceneManager.LoadScene("Level 1");
    }

    public void Authors()
    {
        AuthorsAnim.SetBool("IsClicked", !AuthorsAnim.GetBool("IsClicked"));
    }

    public void Exit()
    {
        Application.Quit();
    }


}
