using UnityEngine;
using TMPro;

public class CoinAmountText : MonoBehaviour
{
    [SerializeField] private TMP_Text _amountText;

    private void SetCoinAmount(PlayerController player)
    {
        _amountText.text = player.GetCoinAmount().ToString();
    }
}
