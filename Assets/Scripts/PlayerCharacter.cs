using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
 * 玩家角色类
 */
public class PlayerCharacter : AbstractCharacter
{

    public CardPile playerCardPile;
    public int energy;//精力
    public int endurance;//耐力值
    private bool isInitialCardPileDone;

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
    }

    // Start is called before the first frame update
    void Start()
    {
        isInitialCardPileDone = false;
    }

    public void AddCardToPlayerCardPile(int x)
    {
        CardCreater cardCreater = gameRun.cardCanvas.GetComponent<CardCreater>();
        AbstractCard c;
        c = cardCreater.CreateSingleCard(gameRun.cardIndex.getCardAt(x));
        playerCardPile.AddCard(c);
    }

    // Update is called once per frame
    void Update()
    {
        if(isInitialCardPileDone == false)
        {
            for(int i = 0; i < 13; i++)
            {
                AddCardToPlayerCardPile(i);
            }
            isInitialCardPileDone = true;
        }
    }
}
