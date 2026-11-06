using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class CharacterTable : DataTable
{
    private readonly Dictionary<string, CharData> table = new Dictionary<string, CharData>();
    public override void Load(string filename)
    {
        table.Clear();
        var path = string.Format(FormatPath, filename);
        var textAsset = Resources.Load<TextAsset>(path);
        var list = LoadCSV<CharData>(textAsset.text);
        foreach (var charac in list)
        {
            if (!table.ContainsKey(charac.Id))
            {
                table.Add(charac.Id, charac);
            }
            else
            {
                Debug.Log("캐릭터 중복");
            }
        }
    }

    public CharData Get(string id)
    {
        if (!table.ContainsKey(id))
        {
            Debug.LogError($"{id}: 캐릭터 없음");
            return null;
        }
        return table[id];
    }

    public CharData GetRandom()
    {
        var characList = table.Values.ToList();
        return characList[Random.Range(0, characList.Count)];
    }

}
