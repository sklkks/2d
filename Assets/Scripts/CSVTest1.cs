using UnityEngine;
using CsvHelper;
using System.IO;
using System.Globalization;
using System;

public class CsvDate
{
    public string Id {get; set;}
    public string String {get; set;}
}
public class CSVTest1 : MonoBehaviour
{
    public UiCharacterInfo CharInfo;
    public UiCharacterButton[] CharButton;
    // public UiItemInfo itemInfo;
    // public UiItemButton[] itemButton;
    private void Start()
    {
        CharButton[0].SetChar("CHAR_1");
        CharButton[0].button.onClick.AddListener(() => CharInfo.SetChar("CHAR_1"));
        CharButton[1].SetChar("CHAR_2");
        CharButton[1].button.onClick.AddListener(() => CharInfo.SetChar("CHAR_2"));
        CharButton[2].SetChar("CHAR_3");
        CharButton[2].button.onClick.AddListener(() => CharInfo.SetChar("CHAR_3"));
        CharButton[3].SetChar("CHAR_4");
        CharButton[3].button.onClick.AddListener(() => CharInfo.SetChar("CHAR_4"));

        // itemButton[0].SetItem("ITEM_1");
        // itemButton[0].button.onClick.AddListener(() => itemInfo.SetItem("ITEM_1"));
        // itemButton[1].SetItem("ITEM_2");
        // itemButton[1].button.onClick.AddListener(() => itemInfo.SetItem("ITEM_2"));
        // itemButton[2].SetItem("ITEM_3");
        // itemButton[2].button.onClick.AddListener(() => itemInfo.SetItem("ITEM_3"));
        // itemButton[3].SetItem("ITEM_4");
        // itemButton[3].button.onClick.AddListener(() => itemInfo.SetItem("ITEM_4"));




    }
    // // private StringTable stringTable ;
    // private void Start()
    // {
    //     // stringTable = DataTableManager.StringTable;
        
    //     // Debug.Log(stringTable.Get("HELLO"));
    //     // Debug.Log(stringTable.Get("BYE"));
    //     // Debug.Log(stringTable.Get("YOU_DIE"));
        
    //     Debug.Log(DataTableManager.StringTable.Get("HELLO"));
    //     Debug.Log(DataTableManager.StringTable.Get("BYE"));
    //     Debug.Log(DataTableManager.StringTable.Get("YOU_DIE"));

    //     var itemData = DataTableManager.ItemTable.Get("ITEM_1");
    //     Debug.Log($"{itemData.StringName}, {itemData.StringDesc}");
    // }

    // public TextAsset textAsset;
    // private void Start()
    // {        
    //     TextAsset csv = Resources.Load<TextAsset>("DataTables/StringTableKr");
    //     using (var reader = new StringReader(csv.text))
    //     using (var csvReader = new CsvReader(reader, CultureInfo.InvariantCulture))
    //     {
    //         var records = csvReader.GetRecords<CsvDate>();
    //         foreach(var record in records)
    //         {
    //             Debug.Log($"{record.Id} : {record.String}");
    //         }
    //     }
    // }
}
