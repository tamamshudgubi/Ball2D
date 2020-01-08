using UnityEngine;

public class LoseCheck : MonoBehaviour
{
    [SerializeField] private GameObject _loseMenu;

    private void OnBecameInvisible()
    {
        Time.timeScale = 0;
        _loseMenu.SetActive(true);
    }
}
