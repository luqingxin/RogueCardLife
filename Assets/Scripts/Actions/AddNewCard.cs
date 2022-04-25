using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

//添加一张新卡到抽牌堆
public class AddNewCard<T> : AbstractGameAction where T:AbstractCard
{
    public  AddNewCard (AbstractGameRun g)
    {
        gameRun = g;
    }

    public override void Effect()
    {
        CardCreater creater =  gameRun.cardCanvas.GetComponent<CardCreater>();
        AbstractCard x =  creater.CreateSingleCard<T>();
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
