using UnityEngine;

public class Bootstrap : MonoBehaviour
{
    [SerializeField] private ClickerView _clickerView;
    private ClickerController _clickerController;
    private ClickerModel _clickerModel;

    private void Awake()
    {
        _clickerModel = new ClickerModel();
        _clickerController = new ClickerController(_clickerView, _clickerModel);
        _clickerController.SetUp();
    }
}
