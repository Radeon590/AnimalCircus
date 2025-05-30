﻿using UnityEngine;

public class EmployeeGeneratedBuilder : MonoBehaviour
{
    private EmployeeGeneratedPreset _result;

    public void Create()
    {
        _result = new EmployeeGeneratedPreset();
    }

    public void SetEmployeePreset(EmployeePreset employeePreset)
    {
        _result.EmployeePreset = employeePreset;
    }
    
    public EmployeeGeneratedPreset Build()
    {
        return _result;
    }
}