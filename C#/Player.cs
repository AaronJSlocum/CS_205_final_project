using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    //fields
    private string name = "Player";
    [SerializeField] private int id;
    private int tilePosition = 0;
    [SerializeField] private int cashVal = 1500;
    private List<Tile> properties;
    private bool jail = false;
    private bool bankruptcy = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public string getName()
    {
        return name;
    }

    public int getID()
    {
        return id;
    }

    public int getPostion()
    {
        return tilePosition;
    }
    public void addMoney(int amount)
    {
        cashVal += amount;
    }
    public void removeMoney(int amount)
    {
        cashVal -= amount;
        //isbankrupt
    }

    internal void setPostion(int pos)
    {
        tilePosition = pos;
    }
}
