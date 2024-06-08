using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EmployeeFlyweightFactory : MonoBehaviour
{
    private List<Employee> _employees;

    public void SetUp(List<Employee> employees)
    {
        _employees = employees;
    }
    
    public Employee GetEmployee()
    {
        Debug.Log(_employees.Count);
        return _employees[Random.Range(0, _employees.Count)];
    }
}
