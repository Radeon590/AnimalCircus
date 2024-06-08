using UnityEngine;
using UnityEngine.Events;

public class BuildingToStationPresetAdapter : MonoBehaviour
{
    public UnityEvent<StationPreset> OnAdapt;

    public void Adapt(IBuilding building)
    {
        OnAdapt?.Invoke((StationPreset)building);
    }
}