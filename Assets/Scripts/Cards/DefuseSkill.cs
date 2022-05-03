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
        this.cardNum = 2;
        SetCardText();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
