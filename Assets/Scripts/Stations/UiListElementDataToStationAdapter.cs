using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class UiListElementDataToStationAdapter : MonoBehaviour
{
    [SerializeField] private UnityEvent<Station> OnAdapt;

    public void Adapt(IUiListElementData data)
    {
        OnAdapt?.Invoke((Station)data);
    }
}
