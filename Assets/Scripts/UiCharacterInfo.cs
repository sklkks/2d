using TMPro;
using UnityEngine;
using UnityEngine.UI;
public class UiCharacterInfo : MonoBehaviour
{
    public TMP_Text textName;
    public Image icon;
    public TMP_Text textHp;
    public TMP_Text textAtk;
    public TMP_Text textDef;
    public TMP_Text textSpeed;

    private CharData data;

    public void SetEmpty()
    {
        data = null;
        textName.text = string.Empty;
        icon.sprite = null;
        textHp.text = null;
        textAtk.text = null;
        textDef.text = null;
        textSpeed.text = null;
    }

    public void SetChar(string id)
    {
        SetChar(DataTableManager.CharacterTable.Get(id));
    }

    public void SetChar(CharData data)
    {
        if(data == null)
        {
            SetEmpty();
            return;
        }
        this.data = data;
        textName.text = data.StringName;
        icon.sprite = data.SpriteIcon;
        textHp.text = data.Hp.ToString();
        textAtk.text = data.Atk.ToString();
        textDef.text = data.Def.ToString();
        textSpeed.text = data.Speed.ToString();
    }
}
