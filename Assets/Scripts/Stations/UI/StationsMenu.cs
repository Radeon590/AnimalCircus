using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class StationsMenu : MonoBehaviour
{
    [SerializeField] private StationsList stationsList;
    [SerializeField] private BuildingsSystemFacade buildingsSystemFacade;

    public void Open()
    {
        if (stationsList.Count == 0)
        {
            foreach (var station in SingletonObjectPresets.Stations)
            {
                stationsList.Append(station, this);
            }
        }
        gameObject.SetActive(true);
    }

    public void Close()
    {
        gameObject.SetActive(false);
    }

    public void SelectStation(Station station)
    {
        buildingsSystemFacade.Build(station);
        Close();
    }
}
