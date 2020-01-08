using UnityEngine;

public class Pause : MonoBehaviour
{
    private enum EGameStates { Play, Pause };

    private EGameStates _state = EGameStates.Play;

    [SerializeField] private GameObject _pauseMenu;

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
        _pauseMenu.SetActive(false);
        Time.timeScale = 1.0f;
    }

    private void StatePause()
    {
        _pauseMenu.SetActive(true);
        Time.timeScale = 0.0f;
    }
}
