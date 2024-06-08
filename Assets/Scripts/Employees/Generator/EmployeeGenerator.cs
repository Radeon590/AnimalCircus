using UnityEngine;

public class EmployeeGenerator : MonoBehaviour
{
    [SerializeField] private EmployeeGeneratedBuilder employeeGeneratedBuilder;

    public EmployeeGeneratedPreset Generate(EmployeePreset employeePreset)
    {
        employeeGeneratedBuilder.Create();
        employeeGeneratedBuilder.SetEmployeePreset(employeePreset);
        return employeeGeneratedBuilder.Build();
    }
}