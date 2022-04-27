using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//遭遇强盗
public class MeetRobber : AbstractRandEvent
{
    private void Start()
    {
        choiceNum = 5;
        choices = new List<GameObject>();
    }

    public override void Check()
    {
        if (CheckColor(gameRun.gameState.pointOfColor[CardColor.RED], 8)&& CheckColor(gameRun.gameState.pointOfColor[CardColor.YELLOW], 8))
            choices[0].GetComponent<EventChoice>().selectable = true;
        else
            choices[0].GetComponent<EventChoice>().selectable = false;

        if (CheckColor(gameRun.gameState.pointOfColor[CardColor.BLUE], 15))
            choices[1].GetComponent<EventChoice>().selectable = true;
        else
            choices[1].GetComponent<EventChoice>().selectable = false;

        if (CheckColor(gameRun.gameState.pointOfColor[CardColor.GREEN], 6) && CheckMoney(20))
            choices[2].GetComponent<EventChoice>().selectable = true;
        else
            choices[2].GetComponent<EventChoice>().selectable = false;

        if (CheckMoney(50))
            choices[3].GetComponent<EventChoice>().selectable = true;
        else
            choices[3].GetComponent<EventChoice>().selectable = false;

        choices[4].GetComponent<EventChoice>().selectable = true;
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
