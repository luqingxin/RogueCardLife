using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
/*
 * 全部卡牌的索引
 */

public class CardIndex : MonoBehaviour
{
    List<Type> cardTypes;
    List<CardColor> cardColors;

    public Type getCardAt(int x)//获取第x号卡牌的Type
    {
        return cardTypes[x];
    }

    // Start is called before the first frame update
    void Start()
    {
        //将卡牌的类加入索引
        cardTypes = new List<Type>();
        
        cardTypes.Add(typeof(AdjustBreathing));
        cardColors.Add(CardColor.RED);

        cardTypes.Add(typeof(Conversation));
        cardColors.Add(CardColor.GREEN);

        cardTypes.Add(typeof(DefuseSkill));
        cardColors.Add(CardColor.YELLOW);

        cardTypes.Add(typeof(FineSword));
        cardColors.Add(CardColor.YELLOW);

        cardTypes.Add(typeof(GreatPill));
        cardColors.Add(CardColor.RED);

        cardTypes.Add(typeof(HandwrittenLetter));
        cardColors.Add(CardColor.GREEN);

        cardTypes.Add(typeof(LongFist));
        cardColors.Add(CardColor.YELLOW);

        cardTypes.Add(typeof(Observe));
        cardColors.Add(CardColor.BLUE);

        cardTypes.Add(typeof(Persuading));
        cardColors.Add(CardColor.GREEN);

        cardTypes.Add(typeof(SilkBag));
        cardColors.Add(CardColor.BLUE);

        cardTypes.Add(typeof(StoragePower));
        cardColors.Add(CardColor.RED);

        cardTypes.Add(typeof(Tenacity));
        cardColors.Add(CardColor.WHITE);

        cardTypes.Add(typeof(Thinking));
        cardColors.Add(CardColor.BLUE);

        cardTypes.Add(typeof(NothingToDo));
        cardColors.Add(CardColor.WHITE);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
