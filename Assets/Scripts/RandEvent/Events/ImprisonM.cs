using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImprisonM : AbstractRandEvent
{
    private void Awake()
    {
        choiceNum = 4;
        choices = new List<EventChoice>();
    }

    public override void Check()
    {
        if(CheckColor(CardColor.RED,20))
            choices[0].selectable = true;
        else
            choices[0].selectable = false;

        if(CheckColor(CardColor.YELLOW,15))
            choices[1].selectable = true;
        else
            choices[1].selectable= false;

        if(CheckColor(CardColor.GREEN,10))
            choices[2].selectable = true;
        else
            choices[2].selectable= false;

        choices[3].selectable = true;
    }

    public override void Effect(int x)
    {
        switch (x)
        {
            case 0:
                BreakDoor();
                break;
            case 1:
                RunAway();
                break;
            case 2:
                NiceTalk();
                break;
            case 3:
                Defeat();
                break;
        }
    }

    private void BreakDoor()
    {

    }

    private void RunAway()
    {

    }

    private void NiceTalk()
    {

    }

    private void Defeat()
    {
        //随机失去卡牌
    }
}
