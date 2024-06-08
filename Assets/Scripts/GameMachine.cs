using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Serialization;

public class GameMachine : MonoBehaviour
{
    [SerializeField] private SingletonObjectPresets singletonObjectPresets;
    [SerializeField] private LaborExchangeFacade laborExchangeFacade;
    [SerializeField] private ListMenu stationsListMenu;
    
    void Start()
    {
        singletonObjectPresets.SetUp();
        laborExchangeFacade.SetUp(SingletonObjectPresets.Employees);
        stationsListMenu.ElementsData = SingletonObjectPresets.Stations.Select(s => (IUiListElementData)s).ToList();
    }
}
