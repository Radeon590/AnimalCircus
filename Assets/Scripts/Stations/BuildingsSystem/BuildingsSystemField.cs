using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingsSystemField : MonoBehaviour
{
    [SerializeField] private List<BuildingsSystemCell> cells;

    //TODO: temporary code
    public static List<BuildingsSystemCell> Cells { get; private set; }
    //

    private void Start()
    {
        Cells = cells;
    }

    public void ShowField()
    {
        SwitchField(true);
    }

    public void HideField()
    {
        SwitchField(false);
    }

    private void SwitchField(bool isVisible)
    {
        foreach (var cell in cells)
        {
            if (cell.Building == null)
            {
                cell.gameObject.SetActive(isVisible);
            }
        }
    }
}
