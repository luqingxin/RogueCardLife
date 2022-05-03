using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//遭遇强盗
public class MeetRobber : AbstractRandEvent
{
    private void Awake()
    {
        choiceNum = 5;
        choices = new List<EventChoice>();
    }

    public override void Check()
    {
        if (CheckColor(CardColor.RED, 8)&& CheckColor(CardColor.YELLOW, 8))
            choices[0].selectable = true;
        else
            choices[0].selectable = false;

        if (CheckColor(CardColor.BLUE, 15))
            choices[1].selectable = true;
        else
            choices[1].selectable = false;

        if (CheckColor(CardColor.GREEN, 6) && CheckMoney(20))
            choices[2].selectable = true;
        else
            choices[2].selectable = false;

        if (CheckMoney(50))
            choices[3].selectable = true;
        else
            choices[3].selectable = false;

        choices[4].selectable = true;
    }

    public override void Effect(int x)
    {
        switch (x)
        {
            case 0:VictoryByForce();break;
            case 1:VictoryBySense(); break;
            case 2:VictoryByMoney();break;
            case 3:LoseMoney();break;
            case 4:Defeat();break;
        }
    }

    private void VictoryByForce()
    {
        gameRun.playerCharacter.money += 50;
    }

    private void VictoryBySense()
    {

    }

    private void VictoryByMoney()
    {
        gameRun.playerCharacter.money -= 20;
    }

    private void LoseMoney()
    {
        gameRun.playerCharacter.money -= 50;
    }

    private void Defeat()
    {
        ChangeMapPosition(0,0);//转移到山寨
    }
}
