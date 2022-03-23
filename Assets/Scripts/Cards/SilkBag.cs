using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
 * 锦囊
 */
public class SilkBag : AbstractCard
{


    public override void Effect()
    {
        addActionToButtom(new RemoveFromPlayerCardPile(this,gameRun));
    }

    // Start is called before the first frame update
    void Start()
    {
        this.pointNums = new List<int>();
        this.cardColors = new List<CardColor>();
        this.pointNums.Add(5);
        this.cardColors.Add(CardColor.BLUE);
        this.isExhaust = true;
        this.cardDescription = "锦囊";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
