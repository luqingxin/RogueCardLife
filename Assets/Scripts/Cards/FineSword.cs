using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
 * 宝剑
 */
public class FineSword : AbstractCard
{


    public override void Effect()
    {
        AddActionToButtom(new RemoveFromPlayerCardPile(this,gameRun));
    }

    // Start is called before the first frame update
    void Start()
    {
        this.pointNums = new List<int>();
        this.cardColors = new List<CardColor>();
        this.pointNums.Add(5);
        this.cardColors.Add(CardColor.YELLOW);
        this.isExhaust = true;
        this.cardDescription = "宝剑";
        gameRun.cardCanvas.GetComponent<CardCreater>().fixCardColor(this);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
