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

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
