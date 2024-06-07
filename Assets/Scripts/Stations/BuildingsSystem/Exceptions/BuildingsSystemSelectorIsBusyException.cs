using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingsSystemSelectorIsBusyException : Exception
{
    public BuildingsSystemSelectorIsBusyException() : base("BuildingsSystemCellSelector is already started selection process"){}
}
