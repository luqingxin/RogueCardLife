using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Xiashan : AbstractRandEvent
{
    private void Start()
    {
        choiceNum = 1;
        choices = new List<GameObject>();
    }

    public override void Check()
    {
        choices[0].GetComponent<EventChoice>().selectable = true;
    }

    public override void Effect(int x)
    {
        if (x == 0)
            GetMove();
    }

    private void GetMove()
    {
        gameRun.playerCharacter.money += 100;
    }
}
