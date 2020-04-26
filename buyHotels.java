public class buyHotels{
   public buyHotels(Player p, Tile t){
      if(t.num_hotel >= 0){
         if(t.tile_position < 10 && t.num_house >= 4){
            int hotel_cost = 50;
            p.cash_val = p.cash_val-hotel_cost;
            t.num_hotel++;
         }
         if(t.tile_position > 10 && t.tile_position < 20 && t.num_house >= 4){
            int hotel_cost = 100;
            p.cash_val = p.cash_val-hotel_cost;
            t.num_hotel++;
         }
         if(t.tile_position > 20 && t.tile_position < 30 && t.num_house >= 4){
            int hotel_cost = 150;
            p.cash_val = p.cash_val-hotel_cost;
            t.num_hotel++;
         }
         if(t.tile_position > 30 && t.num_house >= 4){
            int hotel_cost = 200;
            p.cash_val = p.cash_val-hotel_cost;
            t.num_hotel++;
         }
         else{
            System.out.println("Sorry");
         }
      }  
   }
}
