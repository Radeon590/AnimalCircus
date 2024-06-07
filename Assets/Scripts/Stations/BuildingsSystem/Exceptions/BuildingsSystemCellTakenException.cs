using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingsSystemCellTakenException : Exception
{
    public BuildingsSystemCellTakenException() : base("Cell building not null"){}
}
