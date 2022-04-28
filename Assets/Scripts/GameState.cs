using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
/*
 * 游戏的局内状态，保存了抽牌堆弃牌堆手牌
 */
public class GameState : MonoBehaviour
{
    public CardPile drawPile;//抽牌堆
    public CardPile discardPile;//弃牌堆
    public List<CardPair> cardPairs;//N对牌
    public int swapCost;
    public int discardAndDrawCost;
    public AbstractGameRun gameRun;

    public Dictionary<CardColor, int> pointOfColor;

    public void InitializeBattle()
    {
        if(cardPairs.Count == 0)
        {
            for(int i = 0; i < 6; i++)
            {
                cardPairs.Add(new CardPair());
            }
        }
        for(int i = 0; i < 6; i++)
        {
            cardPairs[i].cardA = null;
            cardPairs[i].cardB = null;
        }
        addActionToTop(new PlayerPileToDraw(gameRun));
        for(int i = 0; i < 12; i++)
        {
            addActionToButtom(new DrawCardAction(gameRun));
        }
    }

    public void DisToDraw()//将牌从弃牌堆移动到抽牌堆
    {
        while(discardPile.cards.Count != 0)
        {
            AbstractCard x = discardPile.DrawCard();
            drawPile.AddCard(x);
            //gameRun.cardAnimationController.
        }
    }

    public void AddPointOfColor(CardColor cl,int x)
    {
        if(cl == CardColor.WHITE)
        {
            return;
        }
        pointOfColor[cl] += x;
        //Debug.Log(cl);
        //Debug.Log(x);
    }

    public void EndRound()
    {

    }

    public void RestartRound()
    {
        
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

    public int DrawCard()//抽一张牌
    {
        AbstractCard y = drawPile.DrawCard();//抽取新牌y到第一个空位
        if(y == null)//如果没牌抽了
        {
            if(discardPile.cards.Count != 0)//如果有弃牌就把弃牌堆挪过去
            {
                addActionToTop(new DrawCardAction(gameRun));
                addActionToTop(new ShuffleDrawPile(gameRun));
                addActionToTop(new DiscardPileToDrawPile(gameRun));
            }
            else//没有弃牌就添加一张新牌
            {
                //补一张新牌
                addActionToTop(new DrawCardAction(gameRun));
                Type t = gameRun.cardIndex.getCardAt(13);//无为
                addActionToTop(new AddNewCard(gameRun,t));
            }
            //addActionToTop(new )
            return -1;
        }
        for(int i=0;i<cardPairs.Count;i++)
        {
            CardPair p = cardPairs[i];
            if (p.cardA == null)
            {
                p.cardA = y;
                //取消抽牌后的check
                //CheckPairAndEffect(p);
                return i * 2;
            }
            if (p.cardB == null)
            {
                p.cardB = y;
                //取消check
                //CheckPairAndEffect(p);
                return i * 2 + 1;
            }
        }
        return -1;
    }

    public bool Exhaust(AbstractCard x)
    {
        foreach (CardPair p in cardPairs)
        {
            if (p.cardA == x)
            {
                p.cardA = null;
            }
            if (p.cardB == x)
            {
                p.cardB = null;
            }
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
            addActionToButtom(new AddColorPoint(p.cardA.cardColors[0], p.cardA.pointNums[0],gameRun));
            addActionToButtom(new AddColorPoint(p.cardB.cardColors[0], p.cardB.pointNums[0],gameRun));
            //弃掉或消耗这两张
            if (p.cardA.isExhaust) 
            { 
                addActionToButtom(new ExhaustCardAction(p.cardA, gameRun)); 
            }
            else
            {
                addActionToButtom(new DiscardCardAction(p.cardA, gameRun));
            }
            if (p.cardB.isExhaust)
            {
                addActionToButtom(new ExhaustCardAction(p.cardB, gameRun));
            }
            else
            {
                addActionToButtom(new DiscardCardAction(p.cardB, gameRun));
            }
            addActionToButtom(new DrawCardAction(gameRun));
            addActionToButtom(new DrawCardAction(gameRun));//再抽两张
            /*DiscardCard(p.cardA);//弃掉这两张
            DiscardCard(p.cardB);
            DrawCard();//再抽两张m  
            DrawCard();*/
            return true;
        }
        return false;
    }

    public bool SwapCard(AbstractCard x,AbstractCard y)//交换两张牌的位置，返回值true表示成功交换，false表示失败
    {
        //Debug.Log(x.cardDescription);
        //Debug.Log(y.cardDescription);
        if (x.cardType == CardType.TASK || y.cardType == CardType.TASK)//任务卡不能被玩家移动
        {
            return false;
        }
        if (gameRun.playerCharacter.energy < swapCost)
        {
            return false;
        }
        gameRun.playerCharacter.energy -= swapCost;//精力减少
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
        if (gameRun.playerCharacter.energy < discardAndDrawCost)
        {
            return false;
        }
        if(DiscardCard(x) == false)
        {
            return false;
        }
        DrawCard();
        gameRun.playerCharacter.energy -= discardAndDrawCost;//精力减少
        return true;
    }

    public void addActionToTop(AbstractGameAction action)
    {
        gameRun.gameActionManager.addActionToTop(action);
    }
    public void addActionToButtom(AbstractGameAction action)
    {
        gameRun.gameActionManager.addActionToBottom(action);
    }

    //返回第x张牌
    public AbstractCard getCardOfInt(int x)
    {
        if(x%2 == 0)
        {
            return cardPairs[x / 2].cardA;
        }
        else
        {
            return cardPairs[x / 2].cardB;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        cardPairs = new List<CardPair>();
        pointOfColor = new Dictionary<CardColor, int>();
        pointOfColor[CardColor.RED] = 0;
        pointOfColor[CardColor.YELLOW] = 0;
        pointOfColor[CardColor.GREEN] = 0;
        pointOfColor[CardColor.BLUE] = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
