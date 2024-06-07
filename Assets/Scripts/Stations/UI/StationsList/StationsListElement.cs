using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StationsListElement : MonoBehaviour
{
    [SerializeField] private Image icon;
    [SerializeField] private Text name;
    
    private Station _station;

    public Station Station => _station;

    private StationsMenu _stationsMenu;

    public void SetUp(Station station, StationsMenu stationsMenu, StationsList stationsList)
    {
        transform.SetParent(stationsList.ElementsContainer);
        _station = station;
        icon.sprite = _station.Sprite;
        name.text = _station.StationName;
        _stationsMenu = stationsMenu;
    }

    public void Select()
    {
        _stationsMenu.SelectStation(_station);
    }
}
