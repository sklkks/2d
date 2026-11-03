using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class KeyboardWindow : GenericWindow
{
    public int maxCharacters = 7;
    public TMP_Text inputField;
    public GameObject rootKeyboard;
    private Button[] keys;
    private string inputText = string.Empty;
    private string inputTextWithCursor = "_";
    private bool isCursorVisible;
    private float blinkTimer;
    private float blinkInterval = 0.5f;
    protected override void Awake()
    {
        base.Awake();
        keys = rootKeyboard.GetComponentsInChildren<Button>();
        foreach(Button button in keys)
        {
            TMP_Text text = button.GetComponentInChildren<TMP_Text>();
            string key = text.text;
            button.onClick.AddListener(() => OnKey(key));
        }
    }
    public void Update()
    {
        blinkTimer += Time.deltaTime;
        if(blinkTimer > blinkInterval)
        {
            blinkTimer = 0f;
            isCursorVisible = !isCursorVisible;
            UpdateInputField();
        }
    }
    public override void Open()
    {
        blinkTimer = 0f;
        isCursorVisible = true;
        SetText(string.Empty);
        base.Open();
    }
    private void SetText(string text)
    {
        if(text.Length > maxCharacters)
        {
            return;
        }
        inputText = text;
        inputTextWithCursor = inputText.Length < maxCharacters ? $"{inputText}_" : inputText;
        inputField.text = inputText;
        UpdateInputField();
    }
    private void UpdateInputField()
    {
        inputField.text = isCursorVisible ? inputTextWithCursor : inputText;
    }
    public void OnCancel()
    {
        SetText(string.Empty);
    }
    public void OnDelete()
    {
        if(inputText.Length > 0)
        {
            SetText(inputText.Substring(0, inputText.Length - 1));
        }
    }
    public void OnAccept()
    {
        manager.Open(Windows.Start);
        inputField.text = string.Empty;
    }

    public void OnKey(string key)
    {
        SetText($"{inputText}{key}");
    }
}
