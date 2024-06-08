using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class UiListElement : MonoBehaviour
{
    [SerializeField] private Image icon;
    [SerializeField] private Text name;
    
    private IUiListElementData _data;

    public IUiListElementData Data => _data;

    public UnityEvent<IUiListElementData> OnSelect;

    public void SetUp(UiList uiList, IUiListElementData data, UnityEvent<IUiListElementData> onSelect)
    {
        transform.SetParent(uiList.ElementsContainer);
        _data = data;
        icon.sprite = _data.UiListSprite;
        name.text = _data.UiListName;
        OnSelect = onSelect;
    }

    public void Select()
    {
        OnSelect.Invoke(_data);
    }
}
