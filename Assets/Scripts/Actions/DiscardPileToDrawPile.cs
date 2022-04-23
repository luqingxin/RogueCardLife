using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//将卡牌从弃牌堆移动到抽牌堆的动作
public class DiscardPileToDrawPile : AbstractGameAction
{
    bool dtdDone;//逻辑上是否完成
    List<AbstractCard> cards;

    public DiscardPileToDrawPile(AbstractGameRun g)
    {
        gameRun = g;
        dtdDone = false;
        cards = new List<AbstractCard>();
    }

    public override void Effect()
    {
        if(dtdDone == false)
        {
            for(int i = 0; i < gameRun.gameState.discardPile.cards.Count; i++)
            {
                cards.Add(gameRun.gameState.discardPile.cards[i]);
            }
            gameRun.gameState.DisToDraw();
            dtdDone = true;
        }
        isDone = true;
        for(int i = 0; i < cards.Count; i++)
        {
            bool a;
            a = gameRun.cardAnimationController.BackDraw(cards[i].gameObject);
            if(a == false)
            {
                isDone = false;
            }
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
