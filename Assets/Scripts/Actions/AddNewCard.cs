using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

//添加一张新卡到抽牌堆
public class AddNewCard : AbstractGameAction
{
    Type card;
    public  AddNewCard(AbstractGameRun g, Type x)
    {
        gameRun = g;
        card = x;
    }

    public override void Effect()
    {
        CardCreater creater =  gameRun.cardCanvas.GetComponent<CardCreater>();
        
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
