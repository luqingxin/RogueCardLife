using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
 * 将一张牌从玩家牌堆中消去
 */
public class RemoveFromPlayerCardPile : AbstractGameAction
{
    public AbstractCard cardToRemove;
    public RemoveFromPlayerCardPile(AbstractCard c,AbstractGameRun g)
    {
        gameRun = g;
        cardToRemove = c;
    }

    public override void Effect()
    {
        List<AbstractCard> cards = gameRun.playerCharacter.playerCardPile.cards;
        for (int i = 0; i < cards.Count; i++)
        {
            if(cards[i].cardNum == cardToRemove.cardNum)
            {
                cards.RemoveAt(i);
                return;
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
