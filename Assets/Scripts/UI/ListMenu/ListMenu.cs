using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Serialization;

public class ListMenu : MonoBehaviour
{
    [SerializeField] private UiList uiList;
    public List<IUiListElementData> ElementsData;
    public UnityEvent<IUiListElementData> OnSelect;

    public void Open()
    {
        if (uiList.Count == 0)
        {
            foreach (var data in ElementsData)
            {
                uiList.Append(data, OnSelect);
            }
        }
        gameObject.SetActive(true);
    }

    public void Close()
    {
        gameObject.SetActive(false);
    }
}
