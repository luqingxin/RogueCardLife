using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
 * 一对牌
 */
public class CardPair
{
    public AbstractCard cardA, cardB;
    public bool isLocked;

    public bool CheckPair()//判断是否为结算对
    {
        return AbstractCard.CardCombine(cardA, cardB);
    }
    [System.Obsolete("use CheckPair")]
    public void CheckLock()
    {
        if (AbstractCard.CardCombine(cardA, cardB))
        {
            isLocked = true;
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
