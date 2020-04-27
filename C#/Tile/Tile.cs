using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Tile : MonoBehaviour
{
    private int tile_position;
    private string tile_name;

    [SerializeField] protected Transform p1Pos;
    [SerializeField] protected Transform p2Pos;
    [SerializeField] protected Transform p3Pos;
    [SerializeField] protected Transform p4Pos;

    protected static UIManager uIManager;
    protected static GameManager gameManager;
    private void Awake()
    {
        uIManager = GameObject.FindGameObjectWithTag("UIManager").GetComponent<UIManager>();
        gameManager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();

        p1Pos = transform.GetChild(0).transform.GetChild(0);
        p2Pos = transform.GetChild(0).transform.GetChild(1);
        p3Pos = transform.GetChild(0).transform.GetChild(2);
        p4Pos = transform.GetChild(0).transform.GetChild(3);
    }
    public Vector3 PlayerPosOnTile(int player)
    {
        switch (player)
        {
            case 1:
                return p1Pos.position;
            case 2:
                return p2Pos.position;
            case 3:
                return p3Pos.position;
            case 4:
                return p4Pos.position;
            default:
                return transform.position;
        }
    }
    //buy / auction

    //pay

    //own

    //draw card

    //pay tax

    //jail visting

    //inJail

    //
    public abstract void Event();

}
