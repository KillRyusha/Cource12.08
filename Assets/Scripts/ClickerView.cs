using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ClickerView : MonoBehaviour
{
    [SerializeField] private Button _clickButton;
    [SerializeField] private Button _clickUpgradeButton;
    [SerializeField] private TMP_Text _moneyText;
    [SerializeField] private TMP_Text _clickUpgradeCostText;
    [SerializeField] private TMP_Text _clickPowerText;
    public Button GetClickButton => _clickButton; 
    public TMP_Text GetMoneyText => _moneyText;
    public TMP_Text GetClickPowerText => _clickPowerText;
    public Button GetClickUpgradeButton => _clickUpgradeButton;
    public TMP_Text GetClickUpgradeCostText => _clickUpgradeCostText; 
}
