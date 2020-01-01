using UnityEngine.UI;
using UnityEngine;
using TMPro;

public class CoinAmountText : MonoBehaviour
{
    [SerializeField] private TMP_Text _amountText;

    public void SetCoinAmount(PlayerController _player)
    {
        _amountText.text = _player.Wallet.ToString();
    }
}
