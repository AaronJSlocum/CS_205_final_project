public class endMortgage {
   public endMortgage(Tile t, Player p){
         p.cash_val = p.cash_val  - (int)1.1*t.mortgage;
   }
}
