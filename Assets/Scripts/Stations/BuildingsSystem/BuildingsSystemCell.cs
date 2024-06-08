using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class BuildingsSystemCell : MonoBehaviour
{
    [SerializeField] private SpriteRenderer cellSpriteRenderer;
    //
    public UnityEvent<IBuilding> OnBuildingSet;
    //
    private IBuilding _building;

    public IBuilding Building
    {
        get => _building;
        set
        {
            if (_building != null)
            {
                throw new BuildingsSystemCellTakenException();
            }
            _building = value;
            cellSpriteRenderer.sprite = value.Sprite;
            OnBuildingSet?.Invoke(value);
        }
    }
}
