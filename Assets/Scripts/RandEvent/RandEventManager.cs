﻿using System.Collections;
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
    public void DeleteCurrentEvent()
    {
        Destroy(gameRun.EventFrame.GetComponent<AbstractRandEvent>());
    }

    public void CreateEvent(Type x)
    {
        gameRun.EventFrame.AddComponent(x);
    }

    public RandEventText GetRandEventText()
    {
        System.Random random = new System.Random();
        int x = random.Next(0, randEventIndex.maxRow - 1);
        return GetEventText(x);
    }
    
    public RandEventText GetEventText(int x)
    {
        return randEventIndex.texts[x];
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
