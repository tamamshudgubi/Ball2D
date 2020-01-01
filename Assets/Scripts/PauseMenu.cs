using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public void BackTOMenu()
    {
        SceneManager.LoadScene("Main Menu");
    }
}
