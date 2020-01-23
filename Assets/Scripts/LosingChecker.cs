using System.Collections;
using UnityEngine;

public class LosingChecker : MonoBehaviour
{
    [SerializeField] private GameObject _loseMenu;

    private IEnumerator SetLoseCondition(PlayerController player)
    {
        yield return new WaitForSecondsRealtime(2f);

        _loseMenu.SetActive(true);
        player.enabled = false;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        PlayerController player = collision.GetComponent<PlayerController>();

        if (player)
        {
            StartCoroutine(SetLoseCondition(player));
        }
    }
}