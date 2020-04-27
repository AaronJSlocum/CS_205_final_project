using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Property : Tile
{
    [SerializeField] bool housing = true;

    [SerializeField] List<Property> monopolyTiles;
    bool hasMonopoly = false;

    [SerializeField]Player owner = null;

    int numHouses = 0;
    bool hasHotel = false;

    [SerializeField] private int cost;
    [SerializeField] private int houseCost;
    [SerializeField] private int rent;
    [SerializeField] private int rent1House;
    [SerializeField] private int rent2House;
    [SerializeField] private int rent3House;
    [SerializeField] private int rent4House;
    [SerializeField] private int rentHotel;
    [SerializeField] private int morgage;
    [SerializeField] private bool isMorgage = false;

    int currentRent = 0;
    private void Awake()
    {
        currentRent = rent;
        p1Pos = transform.GetChild(0).transform.GetChild(0);
        p2Pos = transform.GetChild(0).transform.GetChild(1);
        p3Pos = transform.GetChild(0).transform.GetChild(2);
        p4Pos = transform.GetChild(0).transform.GetChild(3);
    }
    public override void Event()
    {
        if(owner != null && !isMorgage)
        {
            //pay owner
            uIManager.EnablePayUI(true);
            
        }
        else if (isMorgage)
        {
            // free space
            uIManager.EnableAccountEndTurnUI(true);
        }
        else
        {
            //buy / auction
            uIManager.EnableBuyAuctionUI(true);
        }
    }
    public Player GetOwner()
    {
        return owner;
    }
    public int GetRent()
    {
        return currentRent;
    }
    public int GetCost()
    {
        return cost;
    }
    public void Buy(Player owner)
    {
        this.owner = owner;
        this.owner.RemoveMoney(GetCost());
        this.owner.addProperty(this);
        //check for monopoly

    }
}
