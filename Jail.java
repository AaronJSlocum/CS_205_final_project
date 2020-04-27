public class Jail{
    int turns_passed = 0;
    boolean free = false;
    Dice dice = New Dice();

    public void rollForFreedom(Player player){
        dice.roll();
        if(turns_passed < 3) {
            if (dice.getDie1() == dice.getDie2()) {
                free = true;
            } else {
                turns_passed++;
            }
        }
        if(!free && turns_passed >= 3){
            payFine(player);
        }

    }
    public void payFine(Player player){
        player.cash_val -= 50;
        free = true;
    }
}