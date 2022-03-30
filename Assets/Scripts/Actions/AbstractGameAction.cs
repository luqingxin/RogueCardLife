using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * 游戏动作的抽象类，一张卡的效果由数个动作组成
 */

//动作的类型
public enum ActionType
{
    BUFF , DEFUFF
}


public abstract class AbstractGameAction : MonoBehaviour
{
    public AbstractCharacter source;//动作的来源
    public AbstractCharacter target;//动作的目标
    public AbstractGameRun gameRun;//当前游戏
    public int magicNum;//该动作的数值大小

    public double duration;//动作的延迟时间
    public bool isDone;//动作是否已经完成
    public bool isStart;//动作是否已经开始执行


    public AbstractGameAction() { }

    public AbstractGameAction(AbstractCharacter s,AbstractCharacter t,AbstractGameRun g,int n)//游戏动作由来源，目标，当前游戏，数值构建
    {
        source = s;
        target = t;
        gameRun = g;
        magicNum = n;
    }

    public abstract void Effect();

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
