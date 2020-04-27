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

    private void Awake()
    {
        for(int i=0; i < 40; i++)
        {
            tiles.Add(board.transform.GetChild(i).GetComponent<Tile>());
        }
    }
    public Vector3 PlayerPosOnTile(int tile, int player)
    {
        // Tile currentTile = tiles[tile];
        // return currentTile.PlayerPosOnTile(player).position;
        return tiles[tile].PlayerPosOnTile(player);
    }
    public Tile GetTile(int index)
    {
        return tiles[index];
    }
}
