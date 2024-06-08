using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class UiListElementDataAdapter<T> : MonoBehaviour
{
    [SerializeField] private UnityEvent<T> OnAdapt;

    public void Adapt(IUiListElementData data)
    {
        OnAdapt?.Invoke((T)data);
    }
}
