using System.Security.Cryptography;
using UnityEngine;

[System.Serializable]
public class Data
{
    public float points;

    public Data(GameManager gm)
    {
        points = gm.BestPoint;
    }
}