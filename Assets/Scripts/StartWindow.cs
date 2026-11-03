using UnityEditor.PackageManager.UI;
using UnityEngine;
using UnityEngine.UI;

public class StartWindow : GenericWindow
{
    public Button continueButton;
    public Button newgameButton;
    public Button optionButton;

    public bool canContinue = false;

    protected override void Awake()
    {
        base.Awake();

        continueButton.onClick.AddListener(OnClickcontinue);
        newgameButton.onClick.AddListener(OnClicknewgame);
        optionButton.onClick.AddListener(OnClickoption);
    }

    public override void Open()
    {
        continueButton.gameObject.SetActive(canContinue);
        firstSeleted = canContinue ? 
        continueButton.gameObject : newgameButton.gameObject;
        base.Open();
    }

    public void OnClickcontinue()
    {
        manager.Open(Windows.GameOver);
    }
    public void OnClicknewgame()
    {
        manager.Open(Windows.Keyboard);
    }
    public void OnClickoption()
    {
        manager.Open(Windows.Difficulty);  
    }
}






















    