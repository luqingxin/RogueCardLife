using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * 游戏动作控制类，保存动作队列，控制动作执行的游戏效果和动画
 */

//当前状态，等待中或者动作执行中
public enum ActionState
{
    WAITING ,EXECUTING
}

public class GameActionManager : MonoBehaviour
{
    List<AbstractGameAction> actions;//当前动作队列
    ActionState actionState;//当前是否有动作执行
    AbstractGameAction currentAction;//当前执行的队列
    


    public void addActionToBottom(AbstractGameAction action)
    {
        actions.Add(action);
    }

    public void addActionToTop(AbstractGameAction action)
    {
        actions.Insert(0,action);
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(actionState == ActionState.WAITING)
        {
            if(actions.Count != 0)
            {
                currentAction = actions[0];
                actions.RemoveAt(0);
                actionState = ActionState.EXECUTING;
                currentAction.Effect();
            }
        }
        else if(actionState == ActionState.EXECUTING)
        {
            if (currentAction.isDone == true)
            {

            }
            else
            {

            }
        }
    }
}
