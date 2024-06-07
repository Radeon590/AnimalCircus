using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingsSystemTest : MonoBehaviour
{
    [SerializeField] private Sprite testSprite;
    [SerializeField] private BuildingsSystemFacade facade;

    public void Test()
    {
        var building = new BuildingsSystemTestBuilding(testSprite);
        facade.Build(building);
    }
}
