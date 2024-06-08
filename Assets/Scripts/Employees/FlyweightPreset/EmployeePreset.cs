using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

[CreateAssetMenu(fileName = "Employee", menuName = "ObjectPresets/SpawnEmployee", order = 1)]
public class EmployeePreset : ScriptableObject
{
    [SerializeField] protected Sprite sprite;
    public Sprite Sprite => sprite;
    
    [SerializeField] protected string employeeName;
    public string EmployeeName => employeeName;
}
