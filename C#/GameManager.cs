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

    UIManager uIManager;

    int numPlayers = 4;

    int currentPlayer = 1;
    int roll = 7;

    int doublesRolled = 0;
    bool lastRolledDoubles = false;
    private void Awake()
    {
        uIManager = GameObject.FindGameObjectWithTag("UIManager").GetComponent<UIManager>();
        dice = GetComponent<Dice>();
        board = GetComponent<Board>();
        initStart();
    }
    private void initStart()
    {
        //set active players
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
        Debug.Log("Player" + GetCurrentPlayer().GetID() + " Rolled a " + roll + ", Dice " + dice.getDie1() + ", " +dice.getDie2());
        if (dice.IsDoubles())
        {
            Debug.Log("Doubles!");
            doublesRolled++;
            if(doublesRolled >= 3)
            {
                GoToJail();
                return;
            }
            //Extra Turn
            lastRolledDoubles = true;
        }
        //move current player
        StartCoroutine(MovePlayerForwards(roll));
    }


    public IEnumerator MovePlayerForwards(int distnace)
    {
        //for eact distance move player to the next tile wait .2 sec 
        for (int i=0; i < distnace; i++)
        {
            int playerPos = GetCurrentPlayer().GetPostion();
            //current tile if < 39 go to next 
            if (playerPos < 39)
            {
                //move player to next postion
                GetCurrentPlayer().gameObject.transform.position = (board.PlayerPosOnTile(playerPos + 1, GetCurrentPlayer().GetID()));
                GetCurrentPlayer().SetPostion(playerPos+1);
            }
            else
            {
                //if going from board walk to go restart the location index
                //passGo?
                //else go to 0 collect $200
                GetCurrentPlayer().gameObject.transform.position = (board.PlayerPosOnTile(0, GetCurrentPlayer().GetID()));
                GetCurrentPlayer().SetPostion(0);
                PassGo();
            }
            yield return new WaitForSecondsRealtime(.2f);
        }
        //final destionation 
        EvaluateCurrentTile();
    }

   private void EvaluateCurrentTile()
    {
        Tile tile = board.GetTile(GetCurrentPlayer().GetPostion());
        tile.Event();
    }

    public Tile GetCurrentTile()
    {
        return board.GetTile(GetCurrentPlayer().GetPostion());
    }
   public void MovePlayerBackWards(int distnace)
    {

    }
    public void MovePlayerLocation(int location)
    {
        GetCurrentPlayer().gameObject.transform.position = board.PlayerPosOnTile(location, GetCurrentPlayer().GetID());
        GetCurrentPlayer().SetPostion(location);
    }

    public Player GetCurrentPlayer()
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
        GetCurrentPlayer().AddMoney(200);
    }

    private void GoToJail()
    {
        //move player to jail do not collect 200
        //Go To Jail UI
        MovePlayerLocation(10);
    }

    public void EndTurn()
    {
        if (lastRolledDoubles && doublesRolled < 3)
        {
            //extra turn
            lastRolledDoubles = false;
        }
        else
        {
            NextPlayer();
            doublesRolled = 0;
        }
    }
    public void NextPlayer()
    {
        currentPlayer++;
        if(currentPlayer > numPlayers)
        {
            currentPlayer = 1;
        }
        uIManager.ColorUpdate();
    }

   public void PayRent()
   {
        Property property = GetCurrentTile().gameObject.GetComponent<Property>();
        GetCurrentPlayer().Pay(property.GetOwner(), property.GetRent());
   }

    public void PayTax()
    {
        Tax tax = GetCurrentTile().gameObject.GetComponent<Tax>();
        GetCurrentPlayer().RemoveMoney(tax.GetTax());
    }

    public void BuyProperty()
   {
        Property property = GetCurrentTile().gameObject.GetComponent<Property>();
        if (GetCurrentPlayer().GetMoney() > property.GetCost())
        {
            //buy property
            property.Buy(GetCurrentPlayer());

        }
        else
        {
            //auction
            uIManager.EnableBuyAuctionUI(false);
           
        }

   }

}
