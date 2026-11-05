using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class Practice2 : MonoBehaviour
{
    private const byte key = 0XAB;
    private string folder;
    private string path;
    private string encpath;
    private string decpath;
    private void Start()
    {
        
        folder = Path.Combine(Application.persistentDataPath, "ASD");
        if (!Directory.Exists(folder))
        {
            Directory.CreateDirectory(folder);
        }
        path = Path.Combine(folder, "original.txt");
        encpath = Path.Combine(folder, "encrypted.dat");
        decpath = Path.Combine(folder, "decrypted.txt");
    }

    private void WriteOriginal()
    {
        File.WriteAllText(path, "qwerasdf");
    }

    private void Encrypt()
    {
        using (FileStream fsRead = new FileStream(path, FileMode.Open))
        using (FileStream fsWrite = new FileStream(encpath, FileMode.Create))
        {
            int readValue;

            while((readValue = fsRead.ReadByte()) != -1)
            {
                fsWrite.WriteByte((byte)(readValue ^ key));
            }
            string encrypted = File.ReadAllText(encpath);
        } 
    }
        
    private void Decrypt()
    {
        using (FileStream fsRead = new FileStream(encpath, FileMode.Open))
        using (FileStream fsWrite = new FileStream(decpath, FileMode.Create))
        {
            int readValue;

            while((readValue = fsRead.ReadByte()) != -1)
            {
                fsWrite.WriteByte((byte)(readValue ^ key));
            }
            string decrypted = File.ReadAllText(decpath);
        } 
        
    }
}



// using System.Collections.Generic;
// using System.IO;
// using UnityEngine;


// public class Practice2 : MonoBehaviour
// {
//     private const byte key = 0XAB;
//     private string folder;
//     private string path;
//     private string encPath;
//     private string decPath;

//     private void Start()
//     {
        
//         folder = Path.Combine(Application.persistentDataPath, "Secret");
//         if (!Directory.Exists(folder))
//         {
//             Directory.CreateDirectory(folder);
//         }
//         path = Path.Combine(folder, "original.txt");
//         encPath = Path.Combine(folder, "encrypted.dat");
//         decPath = Path.Combine(folder, "decrypted.txt");
//     }

//     private void WriteOriginal()
//     {
//         File.WriteAllText(path, "qwerqwerqwer");
//     }

//     private void Encrypt()
//     {
//         using (FileStream fsRead = new FileStream(path, FileMode.Open))
//         using (FileStream fsWrite = new FileStream(encPath, FileMode.Create))
//         {
//             int readValue;

//             while((readValue = fsRead.ReadByte()) != -1)
//             {
//                 fsWrite.WriteByte((byte)(readValue ^ key));
//             }
//         }
//     }
//     private void Decrypt()
//     {
//         using (FileStream fsRead = new FileStream(encPath, FileMode.Open))
//         using (FileStream fsWrite = new FileStream(decPath, FileMode.Create))
//         {
//             int readValue;

//             while((readValue = fsRead.ReadByte()) != -1)
//             {
//                 fsWrite.WriteByte((byte)(readValue ^ key));
//             }
//         } 
//         string result = File.ReadAllText(decPath);
//         bool equal = result == File.ReadAllText(path);
//     }
// }