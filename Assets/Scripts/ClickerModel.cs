public class ClickerModel
{
    private int _money;
    private int _clickPower;
    public int GetMoney => _money;
    public int GetClickPower => _clickPower;

    public ClickerModel()
    {
        _clickPower = 1;
    }

    public void ChangeMoney(int money)
    {
        if (_money + money < 0)
            return;
        _money += money;
    }
    public void AddClickPower(int clickPower) 
    {
        if (_clickPower <= 0)
            return;
        _clickPower += clickPower;
    }
}
