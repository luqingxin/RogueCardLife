using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

//添加一张新卡到抽牌堆
public class AddNewCard : AbstractGameAction
{

    Type cardType;
    public  AddNewCard (AbstractGameRun g,Type t)
    {
        gameRun = g;
        cardType = t;
    }

    public override void Effect()
    {
        CardCreater creater =  gameRun.cardCanvas.GetComponent<CardCreater>();
        AbstractCard x =  creater.CreateSingleCard(cardType);
        x.gameRun = gameRun;
        x.gameObject.transform.SetParent(gameRun.cardCanvas.transform);
        isDone = true;
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
