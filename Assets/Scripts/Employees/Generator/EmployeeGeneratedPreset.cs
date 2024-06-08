using UnityEngine;

public class EmployeeGeneratedPreset : EmployeePreset, IUiListElementData
{
    public EmployeePreset EmployeePreset { get; set; }
    public Sprite UiListSprite => sprite;
    public string UiListName => employeeName;
}