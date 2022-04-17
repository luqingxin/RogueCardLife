using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//随机事件中某个选项的类的父类
public class AbstractEventChoice
{

    public GameState gameState;
    public AbstractGameRun gameRun;
    public string choiceName;

    //判断条件是否达成
    public virtual bool checkCondition()
    {
        return false;
    }

    public virtual void Effect()
    {

    }

    public void ChangeMoney(int money)
    {
        gameRun.playerCharacter.money += money;
    }
    
    public void ChangePower(int type,int count)
    {
        //type0~3对应三种属性值
        switch(type)
        {
            case 0:gameRun.playerCharacter.strength += count; break;
            case 1: gameRun.playerCharacter.move += count; break;
            case 2: gameRun.playerCharacter.wisdom += count; break;
            case 3: gameRun.playerCharacter.communication += count; break;
        }
    }

    public void ChangeMapPosition(int x,int y)
    {
        gameRun.playerCharacter.mapX = x;
        gameRun.playerCharacter.mapY = y;
    }
}
