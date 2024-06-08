using UnityEngine;

public class EmployeeGeneratedPreset : IUiListElementData
{
    public EmployeePreset EmployeePreset { get; set; }
    public Sprite Sprite => EmployeePreset.Sprite;
    public Sprite UiListSprite => EmployeePreset.Sprite;
    public string UiListName => EmployeePreset.EmployeeName;
}