using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
 * 游戏的局内状态
 */
public class GameState : MonoBehaviour
{
    int maxEnegy;//每回合开始的能量
    int remainedEnegy;//当前剩余能量
    CardPile drawPile;//抽牌堆
    CardPile discardPile;//弃牌堆
    List<CardPair> cardPairs;//N对牌
    const int swapCost = 1;
    const int discardAndDrawCost = 2;

    public void SwapCard(AbstractCard x,AbstractCard y)//交换两张牌的位置
    {
        remainedEnegy -= swapCost;//能量减少
        foreach (CardPair p in cardPairs)
        {
            if(p.cardA == x)
            {
                //还没写的，移动y到牌对p的A位置
                p.cardA = y;
            }
            else if (p.cardA == y)
            {
                //还没写的，移动x到牌对p的A位置
                p.cardA = x;
            }
            if (p.cardB == x)
            {
                //还没写的，移动y到牌对p的B位置
                p.cardB = y;
            }
            else if (p.cardB == y)
            {
                //还没写的，移动x到牌对p的B位置
                p.cardB = x;
            }
            p.CheckLock();
        }
    }

    public void DiscardAndDrawCard(AbstractCard x)//弃牌
    {
        remainedEnegy -= discardAndDrawCost;//能量减少
        AbstractCard y = drawPile.DrawCard();//抽取新牌y
        foreach (CardPair p in cardPairs)
        {
            if (p.cardA == x)
            {
                p.cardA = y;
                discardPile.AddCard(x);
                //还没写的，抽取y和丢弃x
            }
            if (p.cardB == x)
            {
                p.cardB = y;
                discardPile.AddCard(x);
            }
            p.CheckLock();
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
