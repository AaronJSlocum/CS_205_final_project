using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dice : MonoBehaviour
{
    private int die1;
    private int die2;

    public Dice(int die1, int die2)
    {
        this.die1 = die1;
        this.die2 = die2;
    }

    public int getDie1()
    {

        return die1;
    }
    public int getDie2()
    {

        return die2;
    }

    public int roll()
    {
        die1 = Random.Range(1, 7);

        die2 = Random.Range(1, 7);

        return die1 + die2;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
