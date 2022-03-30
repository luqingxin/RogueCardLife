using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//交换两张卡牌的动作
public class SwapCardAction : AbstractGameAction
{

    public AbstractCard cardA, cardB;

    public SwapCardAction(AbstractCard x,AbstractCard y)
    {
        x = cardA;
        y = cardB;
    }

    public override void Effect()
    {
        gameRun.gameState.SwapCard(cardA, cardB);
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
