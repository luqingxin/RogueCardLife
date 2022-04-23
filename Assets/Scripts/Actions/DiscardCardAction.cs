using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
 * 弃牌的动作
 */
public class DiscardCardAction : AbstractGameAction
{
    AbstractCard card;
    bool discardDone;

    public DiscardCardAction(AbstractCard x,AbstractGameRun g)//指定弃牌
    {
        gameRun = g;
        card = x;
        discardDone = false;
    }

    public override void Effect()
    {
        //先执行逻辑上的弃牌
        if(discardDone == false)
        {
            gameRun.gameState.DiscardCard(card);
            discardDone = true;
        }
        //移动物体，如果到达则动作完成
        bool a = gameRun.cardAnimationController.Discard(card.gameObject);
        //Debug.Log(a);
        if (a == true)
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
