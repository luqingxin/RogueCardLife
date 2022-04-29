using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapBlock : MonoBehaviour 
{
    public int type;
    public int x;
    public int y;
    public GameObject block_frame;
    private bool selected = false;
    public AbstractGameRun gameRun;

    public void setRecord()
    {
        Debug.Log(x);
        Debug.Log(y);
        MapManager.targetX = x;
        MapManager.targetY = y;
    }

    public void MouseEnter()
    {
        block_frame.SetActive(true);
    }
    
    public void MouseExit()
    {
        if(!selected)
            block_frame.SetActive(false);
    }

    //点击地图后，选生成一个随机事件，然后初始化战斗
    public void OnMouseUpAsButton()
    {
        Debug.Log("hhh");
        gameRun.playerCharacter.moveToBlockAt(x, y);
        RandEventText randEventText =  gameRun.randEventManager.GetRandEventText();
        gameRun.randEventManager.DeleteCurrentEvent();
        gameRun.randEventManager.CreateEvent(randEventText.randEventType);
        gameRun.gameState.InitializeBattle();
    }
}
