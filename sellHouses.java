public class sellHouses{
   public int sellHouses(Player p, Tile t){
   
      if(t.tile_position < 10 && t.num_house > 0){
         int house_val = 25;
         p.cash_val = p.cash_val+house_val;
         t.num_house++;
      }
      if(t.tile_position > 10 && t.tile_position < 20 && t.num_house > 0){
         int house_val = 50;
         p.cash_val = p.cash_val+house_val;
         t.num_house--;
      }
      if(t.tile_position > 20 && t.tile_position < 30 && t.num_house > 0){
         int house_val = 75;
         p.cash_val = p.cash_val+house_val;
         t.num_house--;
      }
      if(t.tile_position > 30 && t.num_house > 0){
         int house_val = 100;
         p.cash_val = p.cash_val+house_val;
         t.num_house--;
      }
      else{
         System.out.println("Sorry sweetie you don't have any houses to sell : (");
      }
      return p.cash_val;
   }
}
