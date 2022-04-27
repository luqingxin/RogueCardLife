using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
/*
 * 随机事件管理的类，用来抽取随机事件
 */
public class RandEventManager : MonoBehaviour
{
    public AbstractGameRun gameRun;
    public RandEventIndex randEventIndex;

    public AbstractRandEvent GetCurrentEvent()
    {
        return gameRun.EventFrame.GetComponent<AbstractRandEvent>();
    }

    //删除当前事件框上附带的事件
    public void DeleteCurrentEvent()
    {
        Destroy(gameRun.EventFrame.GetComponent<AbstractRandEvent>());
    }


    //将事件x放到事件框上
    public void CreateEvent(Type x)
    {
        Debug.Log(x);
        if (x.IsSubclassOf(typeof(AbstractRandEvent))){
            gameRun.EventFrame.AddComponent(x);
            gameRun.EventFrame.GetComponent<AbstractRandEvent>().gameRun = gameRun;
        }
    }

    public RandEventText GetRandEventText()
    {
        System.Random random = new System.Random();
        int x = random.Next(0, randEventIndex.maxRow - 1);
        return GetEventText(x);
    }
    
    public RandEventText GetEventText(int x)
    {
        //return randEventIndex.texts[x];
        return randEventIndex.texts[2];
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
