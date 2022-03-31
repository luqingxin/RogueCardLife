using System.Collections;
using System.Collections.Generic;
using UnityEngine; 
/*
 * 游戏的局内状态，保存了抽牌堆弃牌堆手牌
 */
public class GameState : MonoBehaviour
{
    CardPile drawPile;//抽牌堆
    CardPile discardPile;//弃牌堆
    public List<CardPair> cardPairs;//N对牌
    const int swapCost = 1;
    const int discardAndDrawCost = 2;
    public AbstractGameRun gameRun;

    public Dictionary<CardColor, int> pointOfColor;

    public void AddPointOfColor(CardColor cl,int x)
    {
        if(cl == CardColor.WHITE)
        {
            return;
        }
        pointOfColor[cl] += x;
        Debug.Log(cl);
        Debug.Log(x);
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
            DrawCard();//再抽两张
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
