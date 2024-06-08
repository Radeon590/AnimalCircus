using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingletonObjectPresets : MonoBehaviour
{
    [SerializeField] private List<Station> stations;

    public static List<Station> Stations { get; private set; }

    [SerializeField] private List<Employee> employees;
    
    public static List<Employee> Employees { get; private set; }

    public void SetUp()
    {
        Stations = stations;
        Employees = employees;
    }
}
