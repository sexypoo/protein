using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;

public class PlayerData : MonoBehaviour
{
    public Data playerData;

    public bool flag;

    void Start()
    {
    }

    [ContextMenu("Save Json Data")]
    public void SaveDataJson()
    {
        string path = Path.Combine(Application.dataPath, "playerData.json");
        string jsonData = JsonUtility.ToJson(playerData, true);
        File.WriteAllText(path, jsonData);
    }

    [ContextMenu("Load Json Data")]
    public void LoadDataJson()
    {
        string path = Path.Combine(Application.dataPath, "playerData.json");
        string jsonData = File.ReadAllText(path);
        playerData = JsonUtility.FromJson<Data>(jsonData);
    }


}

[System.Serializable]
public class Data
{
    public string _name;
    public int _level;
    public int _coin;
    public int _fame;

    public float _energy;
    public float _hungry;
    public float _muscleLoss;

    public bool isDown;

}
