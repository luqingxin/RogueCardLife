using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * 所有卡牌的抽象类
 */

public enum CardColor
{
    RED, BLUE, YELLOW, GREEN, WHITE
}
public enum CardType
{
    NORMAL, TASK//卡牌分为为普通卡和任务卡
}

public abstract class AbstractCard : MonoBehaviour
{
    List<CardColor> cardColors;//颜色集合
    CardType cardType;//类型
    AbstractNonPlayerCharacter cardSource;//卡牌来自哪个NPC
    List<int> pointNums;//点数
    public string cardNum;//编号

    public static bool CardCombine(AbstractCard CardA,AbstractCard CardB)//判断卡牌能否组合
    {
        if (CardA.cardType == CardType.NORMAL && CardB.cardType == CardType.NORMAL)//同时为普通牌，只要有一个属性一样就可以结合
        {
            foreach (int x in CardA.pointNums)
            {
                foreach (int y in CardB.pointNums)
                { 
                    if (x == y) return true;
                }
            }
            foreach (CardColor x in CardA.cardColors)
            {
                foreach (CardColor y in CardB.cardColors)
                {
                    if (x == y) return true;
                }
            }
            if (CardA.cardSource == CardB.cardSource)
            {
                return true;
            }
            return false;
        }
        else
        {
            if (CardA.cardType == CardType.NORMAL || CardB.cardType == CardType.NORMAL)//都为任务牌不能结合，一张普通一张任务牌则要求属性都一样才能结合
            {
                bool numberMatching = false;
                bool colorMatching = false;
                //1.24盘修改，在所有内容中存在相同的点数和颜色即可
                foreach (int x in CardA.pointNums)
                {
                    foreach (int y in CardB.pointNums)
                    {
                        if (x == y) numberMatching = true;
                    }
                }
                foreach (CardColor x in CardA.cardColors)
                {
                    foreach (CardColor y in CardB.cardColors)
                    {
                        if (x == y) colorMatching = true ;
                    }
                }
                if (CardA.cardSource != CardB.cardSource)
                {
                    return false;
                }
                if(numberMatching&&colorMatching)
                    return true;
            }
            return false;
        }
    }

    public abstract void Effect();

}
