using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Station", menuName = "ObjectPresets/SpawnStation", order = 1)]
public class Station : ScriptableObject, IBuilding, IUiListElementData
{
    [SerializeField] private string stationName;
    public string StationName => stationName;
    public string UiListName => stationName;
    //
    [SerializeField] private Sprite sprite;
    public Sprite Sprite => sprite;
    public Sprite UiListSprite => sprite;
    
}
