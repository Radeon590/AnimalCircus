using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TemporaryEmployeeToStationAssigner : MonoBehaviour
{
    private void OnEnable()
    {
        StartCoroutine(AssignCoroutine());
    }

    private IEnumerator AssignCoroutine()
    {
        while (true)
        {
            foreach (var cell in BuildingsSystemField.Cells)
            {
                Debug.Log("cell");
                if (cell.Building != null)
                {
                    Debug.Log("not null cell");
                    WorkStation workStation = cell.GetComponent<WorkStation>();
                    
                    Debug.Log("work station");
                    Debug.Log(workStation);
                    if (workStation.Employee.Count == 0)
                    {
                        Debug.Log("set employee");
                        workStation.SetEmployee(GetComponent<EmployeeSpawnable>().Preset);
                        Destroy(gameObject);
                    }
                }
            }

            yield return new WaitForSeconds(1);
        }
    }
}
