using System;
using UnityEngine;

public class EmployeeSpawner : MonoBehaviour
{
    [SerializeField] private GameObject employeePrefab;
    [SerializeField] private Transform spawnPoint;

    public void Spawn(EmployeeGeneratedPreset employeePreset)
    {
        GameObject newEmployee = Instantiate(employeePrefab);
        EmployeeSpawnable employeeSpawnable;
        if (newEmployee.TryGetComponent(out employeeSpawnable))
        {
            employeeSpawnable.SetUp(spawnPoint, employeePreset);
        }
        else
        {
            throw new Exception("Cant get employeeSpawnable component");
        }
    }
}