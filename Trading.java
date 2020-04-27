import java.util.*;

public class Trading{
   public Trading(Player p, Tile t, Player q, Tile s){
      Scanner jail_cardp = new Scanner(System.in);
      String jail_p = jail_cardp.nextLine();
      Scanner jail_cardq = new Scanner(System.in);
      String jail_q = jail_cardq.nextLine();
      if(jail_p == "yes" || jail_p == "Yes"){
         q.get_out_of_jail_free = true;
      }else if(jail_q == "yes" || jail_q == "Yes"){
         p.get_out_of_jail_free = true;
      }
      Scanner trade = new Scanner(System.in);
      String trade_accept = trade.nextLine();
      if(trade_accept == "yes" || trade_accept == "Yes"){
         p.properties.remove(t);
         q.properties.add(t);
         p.properties.remove(s);
         q.properties.add(s);
      }
      Scanner cash_p = new Scanner(System.in);
      int cashp = cash_p.nextInt();
      Scanner cash_q = new Scanner(System.in);
      int cashq = cash_q.nextInt();
      p.cash_val = p.cash_val + cashq;
      q.cash_val = cashp + q.cash_val;
   }


}
