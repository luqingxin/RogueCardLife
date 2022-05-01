using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TigerOut : AbstractRandEvent
{
    private void Start()
    {
        choiceNum = 3;
        choices = new List<EventChoice>();
    }

    public override void Check()
    {
        if(CheckColor(CardColor.RED,30)&&CheckColor(CardColor.YELLOW,15))
            choices[0].selectable = true;
        else
            choices[0].selectable = false;

        if(CheckColor(CardColor.YELLOW,30))
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
                Beat();
                break;
            case 1:
                Run();
                break;
            case 2:
                Defeat();
                break;
        }
    }

    private void Beat()
    {
        //触发打虎英雄事件
    }

    private void Run()
    {

    }
    private void Defeat()
    {
        //game over
    }
}
