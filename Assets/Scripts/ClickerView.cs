using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ClickerView : MonoBehaviour
{
    [SerializeField] private Button _clickButton;
    [SerializeField] private TMP_Text _moneyText;
    [SerializeField] private TMP_Text _clickPowerText;
    //это всё надо поменять на бубличные свойства с get
    public Button GetClickButton() => _clickButton; 
    public TMP_Text GetMoneyText() => _moneyText;
    public TMP_Text ClickPowerText() => _clickPowerText;    
}
