import java.util.*;

public class Dice {

   private int die1;
   private int die2;
   
   public Dice(int die1, int die2) {
      this.die1 = die1;
      this.die2 = die2;
   }

   public int getDie1() {
   
      return die1;
   }
   public int getDie2() {

      return die2;
   }
   
   public static Dice roll(){
      Random r = new Random();
      int die1 = r.nextInt(6) + 1;
      
      Random r2 = new Random();
      int die2 = r2.nextInt(6) + 1;
      
      return new Dice(die1, die2);
   }

}
