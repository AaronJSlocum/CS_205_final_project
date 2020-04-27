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
    private int turnsInJail = 0;
    private bool bankruptcy = false;

    static UIManager uIManager;
    private void Awake()
    {
        uIManager = GameObject.FindGameObjectWithTag("UIManager").GetComponent<UIManager>();
    }

    public string GetName()
    {
        return name;
    }

    public int GetID()
    {
        return id;
    }

    public int GetPostion()
    {
        return tilePosition;
    }

    public int GetMoney()
    {
        return cashVal;
    }
    public void AddMoney(int amount)
    {
        cashVal += amount;
        uIManager.updatePlayerMoney(id, cashVal);
    }
    public void RemoveMoney(int amount)
    {
        cashVal -= amount;
        uIManager.updatePlayerMoney(id, cashVal);
        //isbankrupt
    }

    internal void SetPostion(int pos)
    {
        tilePosition = pos;
    }

    public void Pay(Player player, int amount)
    {
        RemoveMoney(amount);
        player.AddMoney(amount);       
    }

    public void addProperty(Property property)
    {
       //properties.Add(property);
    }
}
