using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

public class TemporaryWorkStationWorkResultCollector : MonoBehaviour
{
    [SerializeField] private PlayerInput playerInput;
    [SerializeField] private Camera camera;
    //
    private IBuilding _building;
    private UnityAction _onAssign;
    private Vector2 currentPos;

    private void Start()
    {
        AppendEvents();
    }

    private void AppendEvents()
    {
        var pointAction = playerInput.actions["Point"];
        pointAction.performed += OnPoint;
        var clickEvent = playerInput.actions["Click"];
        clickEvent.performed += OnClick;
    }
    
    public void OnPoint(InputAction.CallbackContext context)
    {
        currentPos = context.ReadValue<Vector2>();
    }

    public void OnClick(InputAction.CallbackContext context)
    {
        try
        {
            Vector2 touchPosition = camera.ScreenToWorldPoint(currentPos);
            var hit = Physics2D.Raycast(touchPosition, touchPosition);
            if (hit)
            {
                Debug.Log("hit");
                if (hit.transform.gameObject.TryGetComponent(out WorkStation cell))
                {
                    cell.GainWorkResult();
                }
            }
        }
        catch (Exception ex)
        {
            Debug.Log(ex);
        }
    }
}
