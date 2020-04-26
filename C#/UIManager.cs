using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class UIManager : MonoBehaviour
{
    [SerializeField] private Color p1Color;
    [SerializeField] private Color p2Color;
    [SerializeField] private Color p3Color;
    [SerializeField] private Color p4Color;


    [SerializeField] private GameObject rollUI;
    [SerializeField] private GameObject buyAuctionUI;
    [SerializeField] private GameObject payUI;
    [SerializeField] private GameObject goToJailUI;
    [SerializeField] private GameObject inJailUI;

    [SerializeField] private GameObject accountEndTurnUI;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Roll()
    {
        EnableRollUI(false);
    }

    public void EnableRollUI(bool state)
    {
        rollUI.SetActive(state);
    }

    public void BuyAuction()
    {
        EnableBuyAuctionUI(false);
    }

    public void EnableBuyAuctionUI(bool state)
    {
        buyAuctionUI.SetActive(state);
    }

    public void Pay()
    {
        EnablePayUI(false);
    }

    public void EnablePayUI(bool state)
    {
        payUI.SetActive(state);
    }

    public void GoToJail()
    {
        EnableGoToJailUI(false);
    }

    public void EnableGoToJailUI(bool state)
    {
        goToJailUI.SetActive(state);
    }

    public void InJail()
    {
        EnableInJailUI(false);
    }

    public void EnableInJailUI(bool state)
    {
        inJailUI.SetActive(state);
    }

    public void AccountEndTurn()
    {
        AccountEndTurnUI(false);
        EnableRollUI(true);
    }

    public void AccountEndTurnUI(bool state)
    {
        accountEndTurnUI.SetActive(state);
    }
}
