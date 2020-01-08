using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    [SerializeField] private Animator _authorsAnimator;

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
        _authorsAnimator.SetBool("IsClicked", !_authorsAnimator.GetBool("IsClicked"));
    }

    public void Exit()
    {
        Application.Quit();
    }
}
