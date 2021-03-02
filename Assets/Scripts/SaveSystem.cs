using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public static class SaveSystem
{
    public static string saveFileName;
    private static string savePath = Application.persistentDataPath + "/{saveFileName}";

    public static void SaveGame()
    {
        BinaryFormatter bf = new BinaryFormatter();
        FileStream file = File.Create(savePath);
        SaveData data = new SaveData();

        data.BoneData = BoneCollection.boneData;

        bf.Serialize(file, data);
        file.Close();
        Debug.Log("Game data saved to local!");
    }

    public static void LoadGame()
    {
        if (File.Exists(savePath))
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream file = File.Open(savePath, FileMode.Open);
            SaveData data = (SaveData)bf.Deserialize(file);
            file.Close();

            BoneCollection.boneData = data.BoneData;

            Debug.Log("Local game data loaded!");
        }
        else
            Debug.LogError("There is no save data!");
    }
}

[System.Serializable]
public class SaveData
{
    public BoneCollectionData BoneData;
}
