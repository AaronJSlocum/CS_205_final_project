using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class UIManager : MonoBehaviour
{
    [SerializeField] private Color p1Color;
    [SerializeField] private Color p2Color;
    [SerializeField] private Color p3Color;
    [SerializeField] private Color p4Color;


    [SerializeField] private TextMeshProUGUI p1MoneyText;
    [SerializeField] private TextMeshProUGUI p2MoneyText;
    [SerializeField] private TextMeshProUGUI p3MoneyText;
    [SerializeField] private TextMeshProUGUI p4MoneyText;


    [SerializeField] List<Image> playerColorImages;
    [SerializeField] List<TextMeshProUGUI> playerColorTexts;

    [SerializeField] private GameObject rollUI;
    [SerializeField] private GameObject buyAuctionUI;
    [SerializeField] private GameObject payUI;
    [SerializeField] private GameObject payTaxUI;
    [SerializeField] private GameObject goToJailUI;
    [SerializeField] private GameObject inJailUI;

    [SerializeField] private GameObject accountEndTurnUI;
    GameManager gameManager;
    private void Awake()
    {
        gameManager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
    }
    public void ColorUpdate()
    {
        int player = gameManager.GetCurrentPlayer().GetID();
        Color color;
        String text;
        switch (player)
        {
            case 1:
                color = p1Color;
                text = "P1";
                break;
            case 2:
                color = p2Color;
                text = "P2";
                break;
            case 3:
                color = p3Color;
                text = "P3";
                break;
            default:
                color = p4Color;
                text = "P4";
                break;
        }

        foreach(Image p in playerColorImages){
            p.color = color;
        }
        foreach (TextMeshProUGUI t in playerColorTexts)
        {
            t.text = text;
        }
    }
    public void EnableRollUI(bool state)
    {
        rollUI.SetActive(state);
    }

    public void EnableBuyAuctionUI(bool state)
    {
        buyAuctionUI.SetActive(state);
    }

    public void EnablePayUI(bool state)
    {
        payUI.SetActive(state);
    }

    public void EnablePayTaxUI(bool state)
    {
        payTaxUI.SetActive(state);
    }

    public void EnableGoToJailUI(bool state)
    {
        goToJailUI.SetActive(state);
    }

    public void EnableInJailUI(bool state)
    {
        inJailUI.SetActive(state);
    }

    public void EnableAccountEndTurnUI(bool state)
    {
        accountEndTurnUI.SetActive(state);
    }

    public void updatePlayerMoney(int player, int money)
    {
        switch (player)
        {
            case 1:
                p1MoneyText.text = "$" + money;
                break;
            case 2:
                p2MoneyText.text = "$" + money;
                break;
            case 3:
                p3MoneyText.text = "$" + money;
                break;
            default:
                p4MoneyText.text = "$" + money;
                break;
        }
    }
}
