using System.Collections.Generic;
using UnityEngine;

public class EmployeeFlyweightFactory : MonoBehaviour
{
    private List<EmployeePreset> _employees;

    public void SetUp(List<EmployeePreset> employees)
    {
        _employees = employees;
    }
    
    public EmployeePreset GetEmployee()
    {
        Debug.Log(_employees.Count);
        return _employees[Random.Range(0, _employees.Count)];
    }
}