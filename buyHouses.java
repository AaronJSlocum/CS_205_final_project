public class buyHouses{
   public int buyHouses(Player p, Tile t){
   
      if(t.tile_position < 10 && t.num_house < 4){
         int house_cost = 50;
         p.cash_val = p.cash_val-house_cost;
         t.num_house++;
      }
      if(t.tile_position > 10 && t.tile_position < 20 && t.num_house < 4){
         int house_cost = 100;
         p.cash_val = p.cash_val-house_cost;
         t.num_house++;
      }
      if(t.tile_position > 20 && t.tile_position < 30 && t.num_house < 4){
         int house_cost = 150;
         p.cash_val = p.cash_val-house_cost;
         t.num_house++;
      }
      if(t.tile_position > 30 && t.num_house < 4){
         int house_cost = 200;
         p.cash_val = p.cash_val-house_cost;
         t.num_house++;
      }
      else{
         System.out.println("Sorry, you have too many houses on one tile :/");
      }
      return t.num_house;
   }
}
