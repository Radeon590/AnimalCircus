using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

[CreateAssetMenu(fileName = "Employee", menuName = "ObjectPresets/SpawnEmployee", order = 1)]
public class EmployeePreset : ScriptableObject
{
    [SerializeField] protected Sprite sprite;
    [SerializeField] protected string employeeName;
}
