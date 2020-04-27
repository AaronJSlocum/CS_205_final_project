using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    //fields
    private string name = "Player";
    [SerializeField] private int id;
    [SerializeField] private int tilePosition = 0;
    [SerializeField] private int cashVal = 1500;
    private List<Tile> properties;
    [SerializeField] private bool isJailed = false;
    private int turnsInJail = 0;
    private bool bankruptcy = false;
    private int getOutOfJailFreeCards = 0;
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
        if(cashVal <= 0)
        {
            bankruptcy = true;
        }
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

    public void AddProperty(Property property)
    {
       //properties.Add(property);
    }

    public void RollForFreedom(bool isDoubles)
    {
        if (turnsInJail < 3)
        {
            if (isDoubles)
            {
                isJailed = false;
            }
            else
            {
                turnsInJail++;
            }
        }
        if (isJailed && turnsInJail >= 3)
        {
            PayFine();
        }

    }
    public void PayFine()
    {
        RemoveMoney(50);
        isJailed = false;
    }
    public void GetOutofJailFree()
    {
        if (getOutOfJailFreeCards > 0)
        {
            getOutOfJailFreeCards--;
            isJailed = false;
        }
    }

    public bool IsJailed()
    {
        return isJailed;
    }
}
