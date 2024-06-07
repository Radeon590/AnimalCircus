using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Station", menuName = "Stations/SpawnStation", order = 1)]
public class Station : ScriptableObject, IBuilding
{
    [SerializeField] private string stationName;

    public string StationName => stationName;
    
    [SerializeField] private Sprite sprite;
    public Sprite Sprite => sprite;
}
