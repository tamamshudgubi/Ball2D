using System.Collections;
using UnityEngine;

public class LosingCheck : MonoBehaviour
{
    [SerializeField] private GameObject _loseMenu;

    private bool _isLose;

    private IEnumerator SetLosingState(PlayerController player)
    {
        _loseMenu.SetActive(!_isLose);
        player.enabled = _isLose;

        yield return null;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        PlayerController player = collision.GetComponent<PlayerController>();

        if (player)
        {
            StartCoroutine(SetLosingState(player));
        }
    }
}