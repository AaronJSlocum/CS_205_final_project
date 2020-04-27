using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tax : Tile
{
    [SerializeField] int taxtAmount;
  
    public override void Event()
    {
        uIManager.EnablePayTaxUI(true);
    }

    internal int GetTax()
    {
        return taxtAmount;
    }
}
