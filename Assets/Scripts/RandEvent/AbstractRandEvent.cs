using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
 * 随机事件的抽象类
 */
public class AbstractRandEvent : MonoBehaviour
{
    public AbstractGameRun gameRun;
    public string eventName;
    public int choiceNum;
    public List<EventChoice> choices;

    public int HappenPossibility()
    {
        return 0;
    }

    public virtual void Check()
    {
    }

    public virtual void Effect(int x)
    {

    }

    public void AddActionToTop(AbstractGameAction action)
    {
        gameRun.gameActionManager.AddActionToTop(action);
    }
    public void AddActionToButtom(AbstractGameAction action)
    {
        gameRun.gameActionManager.AddActionToBottom(action);
    }

    public bool CheckColor(CardColor color , int colorNumInNeed)
    {
        if (gameRun.gameState.pointOfColor[color]>=colorNumInNeed)
        {
            return true;
        }
        return false;
    }

    public bool CheckMoney(int numInneed)
    {
        if (gameRun.playerCharacter.money >= numInneed)
            return true;
        return false;
    }

    public void ChangeMoney(int money)
    {
        gameRun.playerCharacter.money += money;
    }

    public void ChangeFood(int food)
    {
        gameRun.playerCharacter.food += food;
    }

    public void ChangePower(int type, int count)
    {
        //type0~3对应三种属性值
        switch (type)
        {
            case 0: gameRun.playerCharacter.strength += count; break;
            case 1: gameRun.playerCharacter.move += count; break;
            case 2: gameRun.playerCharacter.wisdom += count; break;
            case 3: gameRun.playerCharacter.communication += count; break;
        }
    }

    public void ChangeMapPosition(int x, int y)
    {
        gameRun.playerCharacter.mapX = x;
        gameRun.playerCharacter.mapY = y;
    }
}
