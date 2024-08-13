using TMPro;
using UnityEngine;

public class ClickerController : MonoBehaviour
{
    [SerializeField] private ClickerView _clickerView;
    private ClickerModel _clickerModel = new ClickerModel();
    private TMP_Text _moneyText;
    private int _clickPower;

    private void Awake()
    {
        _clickPower = _clickerModel.GetClickPower;
        _moneyText = _clickerView.GetMoneyText();
        _clickerView.GetClickButton().onClick.AddListener(ButtonClick);
    }
    private void ButtonClick()
    {
        _clickerModel.ChangeMoney(_clickPower);
        _moneyText.text = "Money: " + _clickerModel.GetMoney;
    }
}