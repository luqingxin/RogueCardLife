using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wuguan : AbstractRandEvent
{
   
    void Awake()
    {
        choiceNum = 2;
        choices = new List<EventChoice>();
    }

    public override void Check()
    {
        if(CheckColor(CardColor.RED,10)&&CheckColor(CardColor.YELLOW,10))
            choices[0].selectable = true;
        else
            choices[0].selectable = false;

        choices[1].selectable = true;
    }

    public override void Effect(int x)
    {
        switch(x)
        {
            case 0:
                Fight();
                break;
            case 1:
                Watch();
                break;
        }
    }

    private void Fight()
    {

    }

    private void Watch()
    {
        //获得卡牌
    }
}
