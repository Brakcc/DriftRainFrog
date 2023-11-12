using UnityEngine;
using System.IO;

public static partial class SavePlayerData
{
    public static void SavePlayer(GameManager gm)
    {
        string path = Application.persistentDataPath + "/datas.data";
        Data lastData = new (gm);
        File.WriteAllText(path, lastData.points.ToString());
    }

    public static string[] LoadPlayer()
    {
        string path = $"{Application.persistentDataPath}/datas.data";
        if (File.Exists(path))
        {
            string playerData;
            string[] datasString;
            playerData = File.ReadAllText(path);
            datasString = Fonctions.UnpackData(playerData);
            return datasString;
        }
        else { return null; }
    }

    #region LoadData
    public static float LoadPoints()
    {
        if (LoadPlayer() != null)
        {
            string mode = LoadPlayer()[0];
            float modeData = float.Parse(mode);
            return modeData;
        }
        else { return 0; }
    }
    #endregion
}