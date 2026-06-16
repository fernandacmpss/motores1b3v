using UnityEngine;
using TMPro;

public class CoinUI : MonoBehaviour
{
    [SerializeField]
    private TMP_Text coinText;

    private void OnEnable()
    {
        PlayerObserverManager.OnCoinCollected += UpdateUI;
    }

    private void OnDisable()
    {
        PlayerObserverManager.OnCoinCollected -= UpdateUI;
    }

    private void Start()
    {
        coinText.text = "Moedas: 0";
    }

    private void UpdateUI(int totalCoins)
    {
        coinText.text = "Moedas: " + totalCoins;
    }
}