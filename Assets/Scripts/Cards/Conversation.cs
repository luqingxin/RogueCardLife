﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
 * 交谈
 */
public class Conversation : AbstractCard
{


    public override void Effect()
    {
        
    }

    // Start is called before the first frame update
    void Start()
    {
        this.pointNums = new List<int>();
        this.cardColors = new List<CardColor>();
        this.pointNums.Add(1);
        this.cardColors.Add(CardColor.GREEN);
        this.cardDescription = "交谈";
        gameRun.cardCanvas.GetComponent<CardCreater>().fixCardColor(this);
        this.cardNum = 6;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
