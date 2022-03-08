using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
 * 抽牌的动作
 */
public class DrawCardAction : AbstractGameAction
{

    public DrawCardAction(AbstractGameRun g)
    {
        gameRun = g;
    }

    public override void Effect()
    {
        gameRun.gameState.DrawCard();
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
