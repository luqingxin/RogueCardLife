﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
 * 随机事件的抽象类
 */
public class AbstractRandEvent : MonoBehaviour
{
    public GameState gameState;
    public AbstractGameRun gameRun;
    public int HappenPossibility()
    {
        return 0;
    }

    public void Effect() { }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
