using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
 * 坚韧
 */
public class Tenacity : AbstractCard
{


    public override void Effect()
    {
        //throw new System.NotImplementedException();
    }

    // Start is called before the first frame update
    void Start()
    {
        this.pointNums = new List<int>();
        this.cardColors = new List<CardColor>();
        this.cardNum = 13;
        SetCardText();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
