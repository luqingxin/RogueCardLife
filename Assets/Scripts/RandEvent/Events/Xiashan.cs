using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Xiashan : AbstractRandEvent
{
    private void Awake()
    {
        choiceNum = 1;
        choices = new List<EventChoice>();
    }

    public override void Check()
    {
        choices[0].selectable = true;
    }

    public override void Effect(int x)
    {
       GetMove();
    }

    private void GetMove()
    {
        gameRun.playerCharacter.money += 100;
    }
}
