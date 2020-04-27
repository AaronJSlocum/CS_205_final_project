using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FreeParking : Tile
{
    public override void Event()
    {
        uIManager.EnableAccountEndTurnUI(true);
    }
}
