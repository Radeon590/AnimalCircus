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
        Debug.Log(newEmployeeGenerated.Sprite);
        Debug.Log(JsonUtility.ToJson(newEmployeeGenerated));
        employeeListMenu.ElementsData.Add(newEmployeeGenerated);
    }

    public void SpawnEmployee(EmployeeGeneratedPreset employeePreset)
    {
        employeeSpawner.Spawn(employeePreset);
    }
}
