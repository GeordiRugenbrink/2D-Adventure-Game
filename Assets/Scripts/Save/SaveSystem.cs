using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System;

public static class SaveSystem
{
    //TODO: Change this class so all data that needs to be saved goes into one class that this class reads!
    public static void Save() {
        try {
            BinaryFormatter formatter = new BinaryFormatter();
            string path = Application.persistentDataPath + "/player.data";
            FileStream stream = new FileStream(path, FileMode.Create);

            SaveData data = new SaveData(new LevelData(Utility.levelManager), new PlayerHealthData(Utility.playerHealthManager));

            formatter.Serialize(stream, data);
            stream.Close();
        }
        catch (Exception e) {
            Debug.LogError(e.Message.ToString());
        }
    }

    public static SaveData Load() {

        string path = Application.persistentDataPath + "/player.data";
        try {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);

            SaveData data = (SaveData)formatter.Deserialize(stream);
            stream.Close();

            return data;

        }
        catch {
            Debug.LogError("Save file not found in " + path);
            return null;
        }
    }
}
