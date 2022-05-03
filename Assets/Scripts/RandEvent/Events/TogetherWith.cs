using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TogetherWith : AbstractRandEvent
{

    void Awake()
    {
        choiceNum = 3;
        choices = new List<EventChoice>();
    }

    public override void Check()
    {
        if(CheckColor(CardColor.GREEN,5))
            choices[0].selectable = true;
        else
            choices[0].selectable = false;

        choices[1].selectable = true;
        choices[2].selectable = true;
    }

    public override void Effect(int x)
    {
        switch (x)
        {
            case 0:
                NiceJob();
                break;
            case 1:
                Alright();
                break;
            case 2:
                Refuse();
                break;
        }
    }

    private void NiceJob()
    {
        //回复至体力上限
        //下回合颜色均+1
    }
    
    private void Alright()
    {
        //回复至体力上限
    }

    private void Refuse()
    {

    }
}
