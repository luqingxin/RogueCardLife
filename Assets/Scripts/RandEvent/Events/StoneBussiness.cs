using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoneBussiness : AbstractRandEvent
{

    void Start()
    {
        choiceNum = 3;
        choices = new List<EventChoice>();
    }

    public override void Check()
    {
        if(CheckMoney(50)&&CheckColor(CardColor.GREEN,10))
            choices[0].selectable = true;
        else
            choices[0].selectable = false;

        if(CheckMoney(20)&&CheckColor(CardColor.GREEN,5))
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
                GoodLookStone();
                break;
            case 1:
                BadLookStone();
                break;
            case 2:
                Noap();
                break;
        }
    }

    private void GoodLookStone()
    {
        if (GoodStoneOrnot(0.75f))
            ChangeMoney(80);
    }

    private void BadLookStone()
    {
        if (GoodStoneOrnot(0.1f))
            ChangeMoney(400);
    }

    private void Noap()
    {

    }

    private bool GoodStoneOrnot(float per)
    {
        int x = Random.Range(0, 100);
        if (x > 100 * per)
            return true;
        
        return false;
    }
}
