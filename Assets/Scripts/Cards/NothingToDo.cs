using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//卡牌无为，抽牌堆不足时的自动补充牌
public class NothingToDo : AbstractCard
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
        this.cardColors.Add(CardColor.WHITE);
        this.cardDescription = "无为";
        gameRun.cardCanvas.GetComponent<CardCreater>().fixCardColor(this);
        this.cardNum = 14;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
