using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingletonObjectPresets : MonoBehaviour
{
    [SerializeField] private List<StationPreset> stations;

    public static List<StationPreset> Stations { get; private set; }

    [SerializeField] private List<EmployeePreset> employees;
    
    public static List<EmployeePreset> Employees { get; private set; }

    public void SetUp()
    {
        Stations = stations;
        Employees = employees;
    }
}
