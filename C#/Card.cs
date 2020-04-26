using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card : MonoBehaviour
{
    //fields 
    private string card_name;
    private string card_description;
    private int cardnum;


    public Card(string card_name, string card_description, int cardnum)
    {
        this.card_name = card_name;
        this.card_description = card_description;
        this.cardnum = cardnum;

    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
