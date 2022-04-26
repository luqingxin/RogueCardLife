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
    public void DeleteCurrentEvent()
    {
        Destroy(gameRun.EventFrame.GetComponent<AbstractRandEvent>());
    }

    public void CreateEvent(Type x)
    {
        gameRun.EventFrame.AddComponent(x);
    }

    public RandEventText GetRandEventText(int x)
    {
        return null;
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
