using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour
{
    private int tile_position;
    private string tile_name;

    private Transform p1Pos;
    private Transform p2Pos;
    private Transform p3Pos;
    private Transform p4Pos;

    private void Awake()
    {
        p1Pos = transform.GetChild(0).transform.GetChild(0);
        p2Pos = transform.GetChild(0).transform.GetChild(1);
        p3Pos = transform.GetChild(0).transform.GetChild(2);
        p4Pos = transform.GetChild(0).transform.GetChild(3);
    }
    public Transform PlayerPosOnTile(int player)
    {
        switch (player)
        {
            case 1:
                return p1Pos;
            case 2:
                return p2Pos;
            case 3:
                return p3Pos;
            default:
                return p4Pos;
        }
    }

    public void Event()
    {
        //buy / auction

        //pay

        //own

        //draw card

        //pay tax

        //jail visting

        //inJail

        //
    }
}
