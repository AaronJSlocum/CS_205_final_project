using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Property : Tile
{
    [SerializeField] bool housing = true;

    bool hasMonopoly = false;
    [SerializeField] List<Property> monopolyTiles;

    int numHouses = 0;
    bool hasHotel = false;

    [SerializeField] private int cost;
    [SerializeField] private int morgage;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
