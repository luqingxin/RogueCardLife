﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
 * 玩家角色类
 */
public class PlayerCharacter : AbstractCharacter
{

    public CardPile playerCardPile;
    public int energy;//精力
    public int food;//食物值
    private bool isInitialCardPileDone;
    private int totCardNum;

    //初始化玩家人物
    public void PlayerCharacterInitialize()
    {
        age = 0;
        strength = 1;
        move = 1;
        wisdom = 1;
        communication = 1;
        mapX = 0;
        mapY = 0;

        money = 100;
    }

    // Start is called before the first frame update
    void Start()
    {
        isInitialCardPileDone = false;
        PlayerCharacterInitialize();
        this.transform.position = gameRun.mapManager.getFloatPosition(new Vector3Int(mapX, mapY, 0));
        transform.SetAsLastSibling();
        totCardNum = 0;
    }

    public void AddCardToPlayerCardPile(int x)
    {
        CardCreater cardCreater = gameRun.cardCanvas.GetComponent<CardCreater>();
        AbstractCard c;
        c = cardCreater.CreateSingleCard(gameRun.cardIndex.getCardAt(x));
        playerCardPile.AddCard(c);
        c.NumInPlayerCardPile = ++totCardNum;
    }

    // Update is called once per frame
    void Update()
    {
        if(isInitialCardPileDone == false)
        {
            for(int i = 0; i < 12; i++)
            {
                AddCardToPlayerCardPile(i);
            }
            isInitialCardPileDone = true;
        }
    }
}
