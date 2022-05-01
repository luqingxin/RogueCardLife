using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Maiyi : AbstractRandEvent
{
    private void Start()
    {
        choiceNum = 4;
        choices = new List<EventChoice>();
    }

    public override void Check()
    {
        if(CheckColor(CardColor.RED, 6) && CheckColor(CardColor.YELLOW, 6))
            choices[0].selectable = true;
        else
            choices[0].selectable = false;
        if(CheckColor(CardColor.BLUE,10))
            choices[1].selectable = true;
        else
            choices[1].selectable = false;
        if(CheckColor(CardColor.GREEN,4) && CheckMoney(20))
            choices[2].selectable = true;
        else
            choices[2].selectable = false;

        choices[3].selectable = true;
    }

    public override void Effect(int x)
    {
        switch (x)
        {
            case 0:
                IWillDoIt();
                break;
            case 1:
                ChangeThought();
                break;
            case 2:
                PoorGuys();
                break;
            case 3:
                Defeat();
                break;
        }
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
    
    private void Defeat()
    {

    }
}
