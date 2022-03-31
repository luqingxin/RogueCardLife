using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
 * 亲笔信
 */
public class HandwrittenLetter : AbstractCard
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
        this.cardColors.Add(CardColor.GREEN);
        this.isExhaust = true;
        this.cardDescription = "亲笔信";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
