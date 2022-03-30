using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//以武服人
public class VictoryByForce : AbstractEventChoice
{

    public override bool checkCondition()
    {
        if(gameState.pointOfColor[CardColor.RED] >= 8 && gameState.pointOfColor[CardColor.YELLOW] >= 8)
        {
            return true;
        }
        return false;
    }
    public override void Effect()
    {

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
