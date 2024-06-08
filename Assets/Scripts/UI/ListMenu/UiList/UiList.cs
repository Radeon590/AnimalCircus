using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class UiList : MonoBehaviour
{
    [SerializeField] private GameObject stationListElementPrefab;
    [SerializeField] private Transform elementsContainer;

    public Transform ElementsContainer => elementsContainer;

    public int Count => elementsContainer.childCount;
    
    public void Append(IUiListElementData data, UnityEvent<IUiListElementData> onSelect)
    {
        Instantiate(stationListElementPrefab).GetComponent<UiListElement>().SetUp(this, data, onSelect);
    }

    public void Clean()
    {
        while (transform.childCount > 0)
        {
            Destroy(transform.GetChild(0).gameObject);
        }
    }
}
