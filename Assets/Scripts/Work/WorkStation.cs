using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class WorkStation : MonoBehaviour
{
    public StationPreset Station;

    public UnityEvent OnWorkDone;
    
    private List<EmployeeGeneratedPreset> _employees;

    public List<EmployeeGeneratedPreset> Employee => _employees;
    
    public void SetUp(StationPreset station)
    {
        Station = station;
        _employees = new List<EmployeeGeneratedPreset>();
        // TODO: temporary code
        GetComponent<SpriteRenderer>().color = Color.gray;
        //
        StartCoroutine(WorkCoroutine());
    }

    public void SetEmployee(EmployeeGeneratedPreset employee)
    {
        _employees.Add(employee);
    }

    private IEnumerator WorkCoroutine()
    {
        while (true)
        {
            yield return new WaitForSeconds(5);
            if (_employees.Count > 0)
            {
                // TODO: temporary code
                GetComponent<SpriteRenderer>().color = Color.yellow;
                //
                OnWorkDone?.Invoke();
            }
        }
    }

    // TODO: temporary code
    public void GainWorkResult()
    {
        GetComponent<SpriteRenderer>().color = Color.gray;
    }
}
