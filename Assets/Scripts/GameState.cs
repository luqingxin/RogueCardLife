using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
 * 游戏的局内状态，保存了抽牌堆弃牌堆手牌
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

    public void EndRound()
    {

    }

    public void RestartRound()
    {
        remainedEnegy = maxEnegy;
    }

    public bool DiscardCard(AbstractCard x)//弃一张牌
    {
        foreach (CardPair p in cardPairs)
        {
            if (p.cardA == x)
            {
                p.cardA = null;
                discardPile.AddCard(x);
            }
            if (p.cardB == x)
            {
                p.cardB = null;
                discardPile.AddCard(x);
            }
            return true;
        }
        return false;
    }

    public bool DrawCard()//抽一张牌
    {
        AbstractCard y = drawPile.DrawCard();//抽取新牌y到第一个空位
        foreach (CardPair p in cardPairs)
        {
            if (p.cardA == null)
            {
                p.cardA = y;
            }
            if (p.cardB == null)
            {
                p.cardB = y;
            }
            CheckPairAndEffect(p);
            return true;
        }
        return false;
    }

    public bool CheckPairAndEffect(CardPair p)//判断结算对和结算
    {
        if (p.CheckPair())
        {
            p.cardA.Effect();//触发卡牌AB的效果
            p.cardB.Effect();
            DiscardCard(p.cardA);//弃掉这两张
            DiscardCard(p.cardB);
            DrawCard();//再抽两张
            DrawCard();
            return true;
        }
        return false;
    }

    public bool SwapCard(AbstractCard x,AbstractCard y)//交换两张牌的位置，返回值true表示成功交换，false表示失败
    {
        if (x.cardType == CardType.TASK || y.cardType == CardType.TASK)//任务卡不能被玩家移动
        {
            return false;
        }
        if (remainedEnegy < swapCost)
        {
            return false;
        }
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
            CheckPairAndEffect(p);
        }
        return true;
    }

    public bool DiscardAndDrawCard(AbstractCard x)//弃牌抽牌
    {
        if (remainedEnegy < discardAndDrawCost)
        {
            return false;
        }
        if(DiscardCard(x) == false)
        {
            return false;
        }
        DrawCard();
        remainedEnegy -= discardAndDrawCost;//能量减少
        return true;
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
