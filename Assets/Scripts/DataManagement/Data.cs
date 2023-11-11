using System.Security.Cryptography;
using UnityEngine;

[System.Serializable]
public class Data
{
    public int points;

    public Data(GameManager gm)
    {
        points = gm.BestPoint;
    }
}