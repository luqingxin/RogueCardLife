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
        this.cardNum = 3;
        SetCardText();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
