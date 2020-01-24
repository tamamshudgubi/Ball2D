using UnityEngine;
using TMPro;

public class CoinAmountText : MonoBehaviour
{
    [SerializeField] private TMP_Text _amountText;

    [SerializeField] private PlayerController _player;

    private void OnEnable()
    {
        _player.CoinCollected += OnCoinCollected;
    }

    private void OnDisable()
    {
        _player.CoinCollected -= OnCoinCollected;
    }

    public void OnCoinCollected(int coinAmount)
    {
        _amountText.text = coinAmount.ToString();
    }
}
