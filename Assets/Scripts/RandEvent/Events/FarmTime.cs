using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FarmTime : AbstractRandEvent
{
    private void Awake()
    {
        choiceNum = 3;
        choices = new List<EventChoice>();
    }

    public override void Check()
    {
        if(CheckColor(CardColor.RED,25))
            choices[0].selectable = true;
        else
            choices[0].selectable = false;

        if(CheckColor(CardColor.RED,10))
            choices[1].selectable = true;
        else
            choices[1].selectable= false;

        choices[2].selectable = true;
    }

    public override void Effect(int x)
    {
        switch (x)
        {
            case 0:
                HugePower();
                break;
            case 1:
                NiceAssistant();
                break;
            case 2:
                Defeat();
                break;
        }
    }

    private void HugePower()
    {
        ChangeMoney(10);
        //获得卡牌
    }

    private void NiceAssistant()
    {
        ChangeMoney(10);
    }

    private void Defeat()
    {
    }
}
