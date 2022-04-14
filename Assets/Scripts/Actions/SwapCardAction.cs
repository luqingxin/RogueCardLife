using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//交换两张卡牌的动作
public class SwapCardAction : AbstractGameAction
{

    public AbstractCard cardA, cardB;
    bool swapDone;

    public SwapCardAction(AbstractCard x,AbstractCard y,AbstractGameRun g)
    {
        cardA = x;
        cardB = y;
        gameRun = g;
        swapDone = false;
    }

    public override void Effect()
    {
        if(swapDone == false)
        {
            gameRun.gameState.SwapCard(cardA, cardB);
            swapDone = true;
            isDone = true;//暂时设置交换动作直接完成，没有动画
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
