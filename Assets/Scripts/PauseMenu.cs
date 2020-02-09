using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public void OnBackToMenuButtonClick()
    {
        SceneManager.LoadScene("Main Menu");
    }
}
