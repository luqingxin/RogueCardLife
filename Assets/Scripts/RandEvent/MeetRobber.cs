using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//遭遇强盗
public class MeetRobber : AbstractRandEvent
{

    public void addActionToTop(AbstractGameAction action)
    {
        gameRun.gameActionManager.addActionToTop(action);
    }
    public void addActionToButtom(AbstractGameAction action)
    {
        gameRun.gameActionManager.addActionToBottom(action);
    }

    public new void Effect()
    {
        if (gameState.pointOfColor[CardColor.RED] >= 8 && gameState.pointOfColor[CardColor.YELLOW] >= 8)//以武服人
        {
            //add
        }
        else if (gameState.pointOfColor[CardColor.BLUE] >= 15)//以理服人
        {

        }
        else if (gameState.pointOfColor[CardColor.GREEN] >= 6)//以钱服人
        {
            
        }
        else//失败
        {

        }
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
