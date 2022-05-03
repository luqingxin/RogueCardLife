using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
 * 观察
 */
public class Observe : AbstractCard
{


    public override void Effect()
    {
        
    }

    // Start is called before the first frame update
    void Start()
    {
        this.pointNums = new List<int>();
        this.cardColors = new List<CardColor>();
        this.cardNum = 4;
        SetCardText();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
