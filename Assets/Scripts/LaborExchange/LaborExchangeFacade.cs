using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaborExchangeFacade : MonoBehaviour
{
    [SerializeField] private EmployeeFlyweightFactory employeeFlyweightFactory;
    [SerializeField] private ListMenu employeeListMenu;
    [SerializeField] private GameObject employeePrefab;
    
    public void SetUp(List<Employee> employeePresets)
    {
        employeeListMenu.ElementsData = new List<IUiListElementData>();
        employeeFlyweightFactory.SetUp(employeePresets);
        UpdateLaborExchange();
    }

    public void UpdateLaborExchange()
    {
        var newEmployee = employeeFlyweightFactory.GetEmployee();
        Debug.Log(employeeFlyweightFactory);
        Debug.Log(newEmployee);
        newEmployee.AppendToListMenu(employeeListMenu);
    }

    public void SpawnEmployee(Employee employee)
    {
        //employee.Spawn();
    }
}
