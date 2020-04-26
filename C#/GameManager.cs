using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    Dice dice;
    Board board;
    [SerializeField] Player p1;
    [SerializeField] Player p2;
    [SerializeField] Player p3;
    [SerializeField] Player p4;


    int numPlayers = 4;
    int roll = 7;   
    int currentPlayer = 1;
    private void Awake()
    {
        dice = GetComponent<Dice>();
        board = GetComponent<Board>();

        initStart();
    }

    private void initStart()
    {

    }
    // Update is called once per frame
    void Update()
    {
        //start of turn
        //roll
        
        //move
        //passGo?
        //evaluate tile
        ////buy/auction/pay
        //account/endTurn
        //next players turn

    }

    public void Roll()
    {
        roll = dice.roll();
        Debug.Log("Player" + GetCurrentPlayer().getID() + " Rolled a " + roll);
        //move current player
        StartCoroutine(MovePlayerForwards(roll));
    }


    public IEnumerator MovePlayerForwards(int distnace)
    {
        //for eact distance move player to the next tile wait .2 sec 
        for (int i=0; i < distnace; i++)
        {
            int playerPos = GetCurrentPlayer().getPostion();
            //current tile if < 39 go to next 
            if (playerPos < 39)
            {
                //move player to next postion
                GetCurrentPlayer().gameObject.transform.position = (board.PlayerPosOnTile(playerPos + 1, GetCurrentPlayer().getID()));
                GetCurrentPlayer().setPostion(playerPos+1);
            }
            else
            {
                //if going from board walk to go restart the location index
                //passGo?
                //else go to 0 collect $200
                GetCurrentPlayer().gameObject.transform.position = (board.PlayerPosOnTile(0, GetCurrentPlayer().getID()));
                GetCurrentPlayer().setPostion(0);
                PassGo();
            }


            yield return new WaitForSecondsRealtime(.2f);
        }
       
      
        //final destionation 

    }

   private void EvaluateCurrentTile()
    {
        Tile tile = board.GetTile(GetCurrentPlayer().getPostion());
        //unOwn 
        //buy / auction menu

        //own pay player

    }
   public void MovePlayerBackWards(int distnace)
    {

    }
    public void MovePlayerLocation(int location)
    {

    }

    private Player GetCurrentPlayer()
    {
        switch (currentPlayer)
        {
            case 1:
                return p1;
            case 2:
                return p2;
            case 3:
                return p3;
            default:
                return p4;
        }
    }

    private void PassGo()
    {
        GetCurrentPlayer().addMoney(200);
    }

    private void nextPlayer()
    {
        currentPlayer++;
        if(currentPlayer > numPlayers)
        {
            currentPlayer = 1;
        }
    }

   

}
