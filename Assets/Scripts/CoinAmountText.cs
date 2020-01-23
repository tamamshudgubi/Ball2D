using UnityEngine;
using TMPro;

public class CoinAmountText : MonoBehaviour
{
    [SerializeField] private TMP_Text _amountText;

    [SerializeField] private PlayerController _player;

    private void OnEnable()
    {
        _player.GetCurrentCoinAmount += SetCoinAmount;
    }

    private void OnDisable()
    {
        _player.GetCurrentCoinAmount -= SetCoinAmount;
    }

    public void SetCoinAmount(int coinAmount)
    {
        _amountText.text = coinAmount.ToString();
    }
}
