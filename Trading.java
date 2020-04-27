import java.util.*;

public class Trading{
   public Trading(Player p, Tile t, Player q, Tile s){
      Scanner trade = new Scanner(System.in);
      String trade_accept = trade.nextLine();
      if(trade_accept == "yes" || trade_accept == "Yes"){
         p.properties.remove(t);
         q.properties.add(t);
         p.properties.remove(s);
         p.properties.add(s);
   
      }
   }


}
