using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
 * 拆招
 */
public class DefuseSkill : AbstractCard
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
        this.cardColors.Add(CardColor.YELLOW);
        this.cardDescription = "拆招";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
