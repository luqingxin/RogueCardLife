using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
 * 思考
 */
public class Thinking : AbstractCard
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
        this.cardColors.Add(CardColor.BLUE);
        this.cardDescription = "思考";
        gameRun.cardCanvas.GetComponent<CardCreater>().fixCardColor(this);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
