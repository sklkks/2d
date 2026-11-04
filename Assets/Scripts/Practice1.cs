using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class Practice1 : MonoBehaviour
{
    private void Start()
    {
        string folder = Path.Combine(Application.persistentDataPath, "SaveData");
        string path1 = Path.Combine(folder, "save1.txt");        
        File.WriteAllText(path1, "123123");
        string path2 = Path.Combine(folder, "save2.txt");        
        File.WriteAllText(path2, "123123");
        string path3 = Path.Combine(folder, "save3.txt");        
        File.WriteAllText(path3, "123123");

        string[] files = Directory.GetFiles(folder);
        foreach(var file in files)
        {
            Debug.Log($"{file} ({Path.GetExtension(file)})");
        }
        string pathDest = Path.Combine(folder, "save1_backup.txt");
        File.Copy(path1, pathDest);
        File.Delete(path3);

        files = Directory.GetFiles(folder);
        foreach(var file in files)
        {
            Debug.Log($"{file} ({Path.GetExtension(file)})");
        }

    }
    
}
