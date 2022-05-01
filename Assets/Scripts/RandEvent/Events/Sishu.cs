using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sishu : AbstractRandEvent
{
    
    void Start()
    {
        choiceNum = 2;
        choices = new List<EventChoice>();
    }

    public override void Check()
    {
        if(CheckColor(CardColor.BLUE,20))
            choices[0].selectable = true;
        else
            choices[0].selectable = false;

        choices[1].selectable = true;
    }

    public override void Effect(int x)
    {
        switch (x)
        {
            case 0:
                Debate();
                break;
            case 1:
                Listen();
                break;
        }
    }

    private void Debate()
    {

    }

    private void Listen()
    {

    }
}
