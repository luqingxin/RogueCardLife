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

    //初始化玩家人物
    public void PlayerCharacterInitialize()
    {
        age = 0;
        strength = 1;
        move = 1;
        wisdom = 1;
        communication = 1;        
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
