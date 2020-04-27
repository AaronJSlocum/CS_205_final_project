using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CommunityChest : CardTile
{

    public override void Event()
    {
        uIManager.EnableAccountEndTurnUI(true);
    }
}
