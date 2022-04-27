using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Maiyi : AbstractRandEvent
{
    private void Start()
    {
        choiceNum = 4;
        choices = new List<GameObject>();
    }

    public override void Check()
    {
        if(CheckColor(gameRun.gameState.pointOfColor[CardColor.RED], 6) && CheckColor(gameRun.gameState.pointOfColor[CardColor.YELLOW], 6))
            choices[0].GetComponent<EventChoice>().selectable = true;
        else
            choices[0].GetComponent<EventChoice>().selectable = false;
        if(CheckColor(gameRun.gameState.pointOfColor[CardColor.BLUE],10))
            choices[1].GetComponent<EventChoice>().selectable = true;
        else
            choices[1].GetComponent<EventChoice>().selectable = false;
        if(CheckColor(gameRun.gameState.pointOfColor[CardColor.GREEN],4) && CheckMoney(20))
            choices[2].GetComponent<EventChoice>().selectable = true;
        else
            choices[2].GetComponent<EventChoice>().selectable = false;

        choices[3].GetComponent<EventChoice>().selectable = true;
    }

    private void IWillDoIt()
    {
        gameRun.playerCharacter.money += 10; 
    }

    private void ChangeThought()
    {
        gameRun.playerCharacter.money += 10;
    }

    private void PoorGuys()
    {
        gameRun.playerCharacter.money -= 20;
        //增加卡牌
    }
}
