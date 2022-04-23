using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
 * 抽牌的动作
 */
public class DrawCardAction : AbstractGameAction
{
    bool drawDone;
    int cardNum;

    public DrawCardAction(AbstractGameRun g)
    {
        gameRun = g;
        drawDone = false;
    }

    public override void Effect()
    {
        if(drawDone == false)
        {
            cardNum = gameRun.gameState.DrawCard();
            drawDone = true;
        }
        if(cardNum != -1)
        {
            AbstractCard card;
            card = gameRun.gameState.getCardOfInt(cardNum);
            bool a;
            a = gameRun.cardAnimationController.DrawCard(card.gameObject, CardPositions.positions[cardNum]);
            if (a == true)
            {
                isDone = true;
            }
        }
        else
        {
            isDone = true;
        }
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
