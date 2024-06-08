using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaborExchangeFacade : MonoBehaviour
{
    [SerializeField] private EmployeeFlyweightFactory employeeFlyweightFactory;
    [SerializeField] private EmployeeGenerator employeeGenerator;
    [SerializeField] private ListMenu employeeListMenu;
    [SerializeField] private EmployeeSpawner employeeSpawner;
    
    public void SetUp(List<EmployeePreset> employeePresets)
    {
        employeeListMenu.ElementsData = new List<IUiListElementData>();
        employeeFlyweightFactory.SetUp(employeePresets);
        UpdateLaborExchange();
    }

    public void UpdateLaborExchange()
    {
        EmployeePreset newEmployee = employeeFlyweightFactory.GetEmployee();
        EmployeeGeneratedPreset newEmployeeGenerated = employeeGenerator.Generate(newEmployee);
        employeeListMenu.ElementsData.Add(newEmployeeGenerated);
    }

    public void SpawnEmployee(EmployeePreset employeePreset)
    {
        employeeSpawner.Spawn(employeePreset);
    }
}
