using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class BuildingsSystemCellSelector : MonoBehaviour
{
    [SerializeField] private Camera camera;
    //
    private Coroutine _currentCoroutine;
    
    public void StartSelectionProcess(IBuilding building, UnityAction onAssign)
    {
        if (_currentCoroutine != null)
        {
            throw new BuildingsSystemSelectorIsBusyException();
        }
        _currentCoroutine = StartCoroutine(AssignBuildingToCellCoroutine(building, onAssign));
    }

    public void CancelSelectionProcess()
    {
        StopCoroutine(_currentCoroutine);
    }

    private IEnumerator AssignBuildingToCellCoroutine(IBuilding building, UnityAction onAssign)
    {
        while (true)
        {
            if (Input.GetMouseButtonDown(0))
            {
                var mousePosition = Input.mousePosition;
                var touchRay = camera.ScreenToWorldPoint(mousePosition);
                var hit = Physics2D.Raycast(touchRay, Vector3.forward);
                if (hit)
                {
                    if (hit.transform.gameObject.TryGetComponent(out BuildingsSystemCell cell))
                    {
                        try
                        {
                            cell.Building = building;
                            onAssign.Invoke();
                            break;
                        }
                        catch (BuildingsSystemCellTakenException ex)
                        {
                            Debug.Log(ex.Message);
                        }
                    }
                }
            }
            yield return new WaitForFixedUpdate();
        }
    }
}
