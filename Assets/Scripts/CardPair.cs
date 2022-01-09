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
    // Start is called before the first frame update

    public void CheckLock()
    {
        if (AbstractCard.CardCombine(cardA, cardB))
        {
            isLocked = true;
        }
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
