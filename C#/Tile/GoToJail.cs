using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoToJail : Tile
{
    public override void Event()
    {
        uIManager.EnableGoToJailUI(true);
    }
}
