using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class Practice2 : MonoBehaviour
{
    private void Start()
    {
        
        string folder = Path.Combine(Application.persistentDataPath, "ASD");
        if (!Directory.Exists(folder))
        {
            Directory.CreateDirectory(folder);
        }
        string path = Path.Combine(folder, "original.txt");
        File.WriteAllText(path, "qwerasdf");

        
        using (FileStream fs = new FileStream(path, FileMode.Open))
        {
            int b = fs.ReadByte();
            Debug.Log($"bite: {b}('{(char)b}')");
        } 
    }
}
