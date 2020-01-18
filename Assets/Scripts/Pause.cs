using UnityEngine;

public class Pause : MonoBehaviour
{
    private enum GameState { Play, Pause };

    [SerializeField] private GameObject _pauseMenu;

    private GameState _state = GameState.Play;

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
            PauseState();
            _state = GameState.Pause;
        }
        else 
        {
            PlayState();
            _state = GameState.Play;
        }
    }

    private void PlayState()
    {
        _pauseMenu.SetActive(false);
        Time.timeScale = 1.0f;
    }

    private void PauseState()
    {
        _pauseMenu.SetActive(true);
        Time.timeScale = 0.0f;
    }
}
