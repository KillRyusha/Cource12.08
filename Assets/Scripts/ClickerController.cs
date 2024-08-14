using TMPro;
using UnityEngine;

public class ClickerController
{
    private const int CLICK_UPGRADE_COST_STEP = 10;
    private const int CLICK_POWER_STEP = 1;
    private const string CLICK_POWER_HEADER = "Click power: ";
    private const string COST_POWER_HEADER = "Cost: ";
    private const string MONEY_HEADER = "Money: ";
    private ClickerView _clickerView;
    private ClickerModel _clickerModel;
    private TMP_Text _moneyText;
    private int _clickPower;

    public ClickerController(ClickerView clickerView, ClickerModel clickerModel)
    {
        _clickerView = clickerView;
        _clickerModel = clickerModel;
    }

    public void SetUp()
    {
        _clickPower = _clickerModel.GetClickPower;
        _moneyText = _clickerView.GetMoneyText;
        _clickerView.GetClickUpgradeCostText.text = COST_POWER_HEADER + _clickerModel.GetClickUpgradeCost;
        _clickerView.GetClickButton.onClick.AddListener(ButtonClick);
        _clickerView.GetClickUpgradeButton.onClick.AddListener(BuyClickPowerUpgrade);
    }
    private void ButtonClick()
    {
        ChangeMoney(_clickPower);
    }

    private void BuyClickPowerUpgrade()
    {
        if (_clickerModel.GetMoney < _clickerModel.GetClickUpgradeCost)
            return;
        ChangeMoney(-_clickerModel.GetClickUpgradeCost);
        _clickerModel.SetClickUpgradeCost(_clickerModel.GetClickUpgradeCost + CLICK_UPGRADE_COST_STEP);
        _clickerModel.AddClickPower(CLICK_POWER_STEP);
        _clickerView.GetClickPowerText.text = CLICK_POWER_HEADER + _clickerModel.GetClickPower;
        _clickerView.GetClickUpgradeCostText.text = COST_POWER_HEADER + _clickerModel.GetClickUpgradeCost;
        _clickPower = _clickerModel.GetClickPower;
    }

    private void ChangeMoney(int amount)
    {
        _clickerModel.ChangeMoney(amount);
        _moneyText.text = MONEY_HEADER + _clickerModel.GetMoney;
    }
}
