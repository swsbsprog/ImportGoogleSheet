using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Newtonsoft.Json;
using System.IO;

public class DataManager : MonoBehaviour
{
    [ContextMenu("ReadJson")]
    void ReadJson()
    {
        var textAsset = Resources.Load("JsonData/MyClass") as TextAsset;
        myClasses = JsonUtility.FromJson<List<MyClass>>(textAsset.text);
        //myClasses = JsonConvert.DeserializeObject<List<MyClass>>(textAsset.text);
        print(myClasses[0].name);
    }

    public string myString = "default111";
    [ContextMenu("SaveJson")]
    void SaveJson()
    {
        var jsonString = JsonUtility.ToJson(this);
        string savePath = Application.dataPath + "/myFile.txt";
        print(savePath);
        File.WriteAllText(savePath, jsonString);
        UnityEditor.AssetDatabase.Refresh();
    }

    [ContextMenu("ReadExcel")]

    void ReadExcel()
    {
        var textAsset = Resources.Load("JsonData/MyClass") as TextAsset ;
        myClasses = JsonConvert.DeserializeObject<List<MyClass>>(textAsset.text);
        print(myClasses[0].name);
    }
    public List<MyClass> myClasses = new List<MyClass>();
}

[System.Serializable]
public class MyClass
{
    public int id;
    public string name;
    public int price;
}
