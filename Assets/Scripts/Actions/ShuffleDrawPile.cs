using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShuffleDrawPile : AbstractGameAction
{

    public ShuffleDrawPile(AbstractGameRun g)
    {
        gameRun = g;
    }

    public override void Effect()
    {
        gameRun.gameState.drawPile.ShuffleCards();
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
