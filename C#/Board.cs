using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Board : MonoBehaviour
{
    //Fields
    [SerializeField] GameObject board;
    public List<Tile> tiles;
    [SerializeField] private int num_houses;
    [SerializeField] private int num_hotels;
    [SerializeField] private List<int> player_position;

    private void Awake()
    {
        for(int i=0; i < 40; i++)
        {
            tiles.Add(board.transform.GetChild(i).GetComponent<Tile>());
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public Vector3 PlayerPosOnTile(int tile, int player)
    {
        Tile currentTile = tiles[tile];

        return currentTile.PlayerPosOnTile(player).position;
    }
    public Tile GetTile(int index)
    {
        return tiles[index];
    }
}
