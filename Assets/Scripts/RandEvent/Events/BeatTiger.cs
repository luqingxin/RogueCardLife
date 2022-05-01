using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeatTiger : AbstractRandEvent
{
    
    void Start()
    {
        choiceNum = 2;
        choices = new List<EventChoice>();
    }

    public override void Check()
    {
        choices[0].selectable = true;
        if(CheckColor(CardColor.BLUE,5)&&CheckColor(CardColor.GREEN,5))
            choices[1].selectable = true;
        else
            choices[1].selectable = false;
    }

    public override void Effect(int x)
    {
        switch (x)
        {
            case 0:
                Accept();
                break;
            case 1:
                Refuse();
                break;
        }
    }

    private void Accept()
    {
        ChangeMoney(500);
        ChangeEndurance(1);
        
    }

    private void Refuse()
    {
        ChangeEndurance(2);
    }
}
