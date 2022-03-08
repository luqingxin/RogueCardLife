using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
 * 说服
 */
public class Persuading : AbstractCard
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
        this.cardColors.Add(CardColor.GREEN);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
