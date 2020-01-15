using UnityEngine;

public class Pause : MonoBehaviour
{
    private enum GameState { Play, Pause };

    private GameState _state = GameState.Play;

    [SerializeField] private GameObject _pauseMenu;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SetState(_state);
        }
    }

    private void SetState(GameState value)
    {
        if (value == GameState.Play)
        {
            StatePause();
            _state = GameState.Pause;
        }
        else 
        {
            StatePlay();
            _state = GameState.Play;
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
