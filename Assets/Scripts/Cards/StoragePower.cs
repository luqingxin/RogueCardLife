﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
 * 蓄力
 */
public class StoragePower : AbstractCard
{


    public override void Effect()
    {
        
    }

    // Start is called before the first frame update
    void Start()
    {
        this.pointNums = new List<int>();
        this.cardColors = new List<CardColor>();
        this.pointNums.Add(2);
        this.cardColors.Add(CardColor.RED);
        this.cardDescription = "蓄力";
        gameRun.cardCanvas.GetComponent<CardCreater>().fixCardColor(this);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
