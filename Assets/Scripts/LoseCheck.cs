using UnityEngine;

public class LoseCheck : MonoBehaviour
{
    public GameObject LoseMenu;

    private void OnBecameInvisible()
    {
        Time.timeScale = 0;
        LoseMenu.SetActive(true);
    }
}
