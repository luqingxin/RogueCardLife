using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
 * 长拳
 */
public class LongFist : AbstractCard
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
        this.cardColors.Add(CardColor.YELLOW);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
