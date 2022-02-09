using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
 * 弃牌的动作
 */
public class DiscardCard : AbstractGameAction
{
    AbstractCard card;
    public DiscardCard(AbstractCard x)//指定弃牌
    {
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
