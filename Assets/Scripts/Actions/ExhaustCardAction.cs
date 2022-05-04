using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
 * 消耗卡牌的动作
 */
public class ExhaustCardAction : AbstractGameAction
{
    AbstractCard card;
    public ExhaustCardAction(AbstractCard x,AbstractGameRun g)
    {
        gameRun = g;
        card = x;
    }

    public override void Effect()
    {
        CreateParticle.Create(card.cardColors[0], card.transform.position);
        gameRun.gameState.Exhaust(card);
        isDone = true;
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
