using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

[CreateAssetMenu(fileName = "Employee", menuName = "ObjectPresets/SpawnEmployee", order = 1)]
public class Employee : ScriptableObject, IUiListElementData
{
    [SerializeField] private Sprite sprite;
    public Sprite UiListSprite => sprite;

    [SerializeField] private string employeeName;
    public string UiListName => employeeName;

    /// <summary>
    /// generate data for list menu and add to it
    /// </summary>
    /// <param name="employeeListMenu"></param>
    public void AppendToListMenu(ListMenu employeeListMenu)
    {
        employeeListMenu.ElementsData.Add(this);
    }
}
