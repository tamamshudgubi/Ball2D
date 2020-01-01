using UnityEngine;

public class Pause : MonoBehaviour
{
    private enum EGameStates { Play, Pause };

    private EGameStates _state = EGameStates.Play;

    public GameObject PauseMenu;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SetState(_state);
        }
    }

    private void SetState(EGameStates value)
    {
        if (value == EGameStates.Play)
        {
            StatePause();
            _state = EGameStates.Pause;
        }
        else 
        {
            StatePlay();
            _state = EGameStates.Play;
        }
    }

    private void StatePlay()
    {
        PauseMenu.SetActive(false);
        Time.timeScale = 1.0f;
    }

    private void StatePause()
    {
        PauseMenu.SetActive(true);
        Time.timeScale = 0.0f;
    }
}
