using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

//添加一张新卡到抽牌堆
public class AddNewCard : AbstractGameAction
{
    bool creatDone;
    Type cardType;
    AbstractCard card;
    public  AddNewCard (AbstractGameRun g,Type t)
    {
        gameRun = g;
        cardType = t;
        creatDone = false;
    }

    public override void Effect()
    {
        if (creatDone == false)
        {
            CardCreater creater = gameRun.cardCanvas.GetComponent<CardCreater>();
            card = creater.CreateSingleCard(cardType);
            card.gameObject.transform.SetParent(gameRun.cardCanvas.transform);
            gameRun.gameState.drawPile.AddCard(card);
            creatDone = true;
        }
        isDone = gameRun.cardAnimationController.BackDraw(card.gameObject);
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
