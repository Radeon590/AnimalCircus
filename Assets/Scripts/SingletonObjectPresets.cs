using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingletonObjectPresets : MonoBehaviour
{
    [SerializeField] private List<Station> stations;

    public static List<Station> Stations { get; private set; }

    public void SetUp()
    {
        Stations = stations;
    }
}
