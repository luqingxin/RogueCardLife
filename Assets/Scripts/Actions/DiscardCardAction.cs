using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
 * 弃牌的动作
 */
public class DiscardCardAction : AbstractGameAction
{
    AbstractCard card;
    public DiscardCardAction(AbstractCard x,AbstractGameRun g)//指定弃牌
    {
        gameRun = g;
        card = x;
    }

    public override void Effect()
    {
        gameRun.gameState.DiscardCard(card);
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
