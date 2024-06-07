using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StationsList : MonoBehaviour
{
    [SerializeField] private GameObject stationListElementPrefab;
    [SerializeField] private Transform elementsContainer;

    public Transform ElementsContainer => elementsContainer;

    public int Count => elementsContainer.childCount;
    
    public void Append(Station station, StationsMenu stationsMenu)
    {
        Instantiate(stationListElementPrefab).GetComponent<StationsListElement>().SetUp(station, stationsMenu, this);
    }

    public void Clean()
    {
        while (transform.childCount > 0)
        {
            Destroy(transform.GetChild(0).gameObject);
        }
    }
}
