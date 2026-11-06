using UnityEngine;
using TMPro;
using UnityEngine.UI;
using Unity.VisualScripting;

public class UiCharacterButton : MonoBehaviour
{
    public Image icon;
    public TMP_Text textName;
    public Button button;

    private CharData data;
    public void SetEmpty()
    {
        data = null;
        icon.sprite = null;
        textName.text = string.Empty;
    }

    public void SetChar(string CharId)
    {
        SetChar(DataTableManager.CharacterTable.Get(CharId));
    }

    public void SetChar(CharData data)
    {
        if(data == null)
        {
            SetEmpty();
            return;
        }
        this.data = data;
        icon.sprite = data.SpriteIcon;
        textName.text = data.StringName;
    }
}
