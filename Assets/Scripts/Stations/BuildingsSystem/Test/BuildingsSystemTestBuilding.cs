using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingsSystemTestBuilding : IBuilding
{
    private Sprite _sprite;

    public Sprite Sprite => _sprite;

    public BuildingsSystemTestBuilding(Sprite sprite)
    {
        _sprite = sprite;
    }
}
