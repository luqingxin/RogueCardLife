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

    private void OnMouseEnter()
    {
        block_frame.SetActive(true);
    }
    
    private void OnMouseExit()
    {
        if(!selected)
            block_frame.SetActive(false);
    }

    private void OnMouseUpAsButton()
    {
        gameRun.playerCharacter.moveToBlockAt(x, y);
    }
}
