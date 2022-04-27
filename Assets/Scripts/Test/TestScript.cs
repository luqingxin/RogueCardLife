﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;
//测试用脚本
public class TestScript : MonoBehaviour
{

    public GameObject testObject;
    public AbstractGameRun gameRun;
    public Sprite sprite;
    public AbstractCard cardA;
    public AbstractCard cardB;

    public void test1()
    {
        Debug.Log("test1");
        Instantiate(testObject);
        Type t = gameRun.cardIndex.getCardAt(0);
        testObject.AddComponent(t);
        Image image =  testObject.GetComponent<Image>();
        AbstractCard card = (AbstractCard)testObject.GetComponent(typeof(AbstractCard));
        sprite = (Sprite)Resources.Load(card.cardPic);
        image.sprite = sprite;
    }

    public void test2()
    {
        CardPair cp = new CardPair();
        cp.cardA = cardA;
        cp.cardB = cardB;
        gameRun.gameState.cardPairs.Add(cp);
    }

    // Start is called before the first frame update
    void Start()
    {
        //test1();
    }

    // Update is called once per frame
    void Update()
    {
        //if(gameRun.gameState.cardPairs.Count == 0)
        //{
        //    test2();
        //}
    }
}
