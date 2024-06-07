using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class BuildingsSystemFacade : MonoBehaviour
{
    [SerializeField] private BuildingsSystemField buildingsSystemField;
    [SerializeField] private BuildingsSystemCellSelector buildingsSystemCellSelector;

    public void Build(IBuilding building)
    {
        buildingsSystemField.ShowField();
        buildingsSystemCellSelector.StartSelectionProcess(building, DoneBuild);
    }

    public void CancelBuild()
    {
        buildingsSystemField.HideField();
        buildingsSystemCellSelector.CancelSelectionProcess();
    }

    private void DoneBuild()
    {
        buildingsSystemField.HideField();
    }
}
