using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "StationPreset", menuName = "ObjectPresets/SpawnStation", order = 1)]
public class StationPreset : ScriptableObject, IBuilding, IUiListElementData
{
    [SerializeField] private string stationName;
    public string StationName => stationName;
    public string UiListName => stationName;
    //
    [SerializeField] private Sprite sprite;
    public Sprite Sprite => sprite;
    public Sprite UiListSprite => sprite;
    
}
