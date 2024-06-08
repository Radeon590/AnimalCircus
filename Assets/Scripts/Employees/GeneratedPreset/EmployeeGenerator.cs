using System;
using UnityEngine;

[RequireComponent(typeof(EmployeeGeneratedBuilder))]
public class EmployeeGenerator : MonoBehaviour
{
    [SerializeField] private EmployeeGeneratedBuilder employeeGeneratedBuilder;

    private void Start()
    {
        if (employeeGeneratedBuilder == null)
        {
            if (!gameObject.TryGetComponent(out employeeGeneratedBuilder))
            {
                Debug.LogError("EmployeeGenerator cant get EmployeeGeneratedBuilder component");
            }
        }
    }

    public EmployeeGeneratedPreset Generate(EmployeePreset employeePreset)
    {
        employeeGeneratedBuilder.Create();
        employeeGeneratedBuilder.SetEmployeePreset(employeePreset);
        return employeeGeneratedBuilder.Build();
    }
}