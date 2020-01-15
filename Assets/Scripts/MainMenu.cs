using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    [SerializeField] private Animator _authorsAnimator;

    private void Start()
    {
        Time.timeScale = 1;
    }

    public void OnPlayButtonClick()
    {
        SceneManager.LoadScene("Level 1");
    }

    public void OnAuthorsButtonClick()
    {
        _authorsAnimator.SetBool("IsClicked", !_authorsAnimator.GetBool("IsClicked"));
    }

    public void OnExitButtonClick()
    {
        Application.Quit();
    }
}
