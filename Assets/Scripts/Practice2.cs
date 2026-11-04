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
        string path1 = Path.Combine(folder, "encrypted.dat");
        string path2 = Path.Combine(folder, "decrypted.txt");

        File.WriteAllText(path, "qwerasdf");

        byte key = 0XAB;

        using (FileStream fsRead = new FileStream(path, FileMode.Open))
        using (FileStream fsWrite = new FileStream(path1, FileMode.Create))
        {
            int readValue;

            while((readValue = fsRead.ReadByte()) != -1)
            {
                fsWrite.WriteByte((byte)(readValue ^ key));
            }
        } 
        using (FileStream fsRead = new FileStream(path1, FileMode.Open))
        using (FileStream fsWrite = new FileStream(path2, FileMode.Create))
        {
            int readValue;

            while((readValue = fsRead.ReadByte()) != -1)
            {
                fsWrite.WriteByte((byte)(readValue ^ key));
            }
        } 
        string original = File.ReadAllText(path);
        string encrypted = File.ReadAllText(path1);
        string decrypted = File.ReadAllText(path2);
    }
}
