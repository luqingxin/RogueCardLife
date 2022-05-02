using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndBattleAction : AbstractGameAction
{
    public EndBattleAction(AbstractGameRun g)
    {
        gameRun = g;
    }

    public override void Effect()
    {
        gameRun.gameState.EndBattle();
        isDone = true;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
