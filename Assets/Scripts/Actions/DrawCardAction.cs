using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
 * 抽牌的动作
 */
public class DrawCardAction : AbstractGameAction
{
    bool drawDone;

    public DrawCardAction(AbstractGameRun g)
    {
        gameRun = g;
        drawDone = false;
    }

    public override void Effect()
    {
        if(drawDone == false)
        {
            gameRun.gameState.DrawCard();
            drawDone = true;
        }
        //if()
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
