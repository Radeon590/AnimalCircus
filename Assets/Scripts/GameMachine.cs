using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class GameMachine : MonoBehaviour
{
    [SerializeField] private SingletonObjectPresets singletonObjectPresets;
    
    void Start()
    {
        singletonObjectPresets.SetUp();
    }
}
