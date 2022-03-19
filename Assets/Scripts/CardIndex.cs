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

    // Start is called before the first frame update
    void Start()
    {
        cardTypes.Add(typeof(AdjustBreathing));
        cardTypes.Add(typeof(Conversation));
        cardTypes.Add(typeof(DefuseSkill));
        cardTypes.Add(typeof(FineSword));
        cardTypes.Add(typeof(GreatPill));
        cardTypes.Add(typeof(HandwrittenLetter));
        cardTypes.Add(typeof(LongFist));
        cardTypes.Add(typeof(Observe));
        cardTypes.Add(typeof(Persuading));
        cardTypes.Add(typeof(SilkBag));
        cardTypes.Add(typeof(StoragePower));
        cardTypes.Add(typeof(Tenacity));
        cardTypes.Add(typeof(Thinking));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
