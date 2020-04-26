public class sellHotels{
   public int sellHotels(Player p, Tile t){
   
      if(t.tile_position < 10 && t.num_hotel > 0){
         int hotel_val = 25;
         p.cash_val = p.cash_val+hotel_val;
         t.num_hotel--;
      }
      if(t.tile_position > 10 && t.tile_position < 20 && t.num_hotel > 0){
         int hotel_val = 50;
         p.cash_val = p.cash_val+hotel_val;
         t.num_hotel--;
      }
      if(t.tile_position > 20 && t.tile_position < 30 && t.num_hotel > 0){
         int hotel_val = 75;
         p.cash_val = p.cash_val+hotel_val;
         t.num_hotel--;
      }
      if(t.tile_position > 30 && t.num_house > 0){
         int hotel_val = 100;
         p.cash_val = p.cash_val+hotel_val;
         t.num_hotel--;
      }
      else{
         System.out.println("Sorry you don't have any hotels to sell : (");
      }
      return p.cash_val;
   }
}
