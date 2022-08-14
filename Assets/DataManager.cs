using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Newtonsoft.Json;

public class DataManager : MonoBehaviour
{
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
