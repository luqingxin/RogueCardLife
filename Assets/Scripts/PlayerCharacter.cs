using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
 * 玩家角色类
 */
public class PlayerCharacter : MonoBehaviour
{
    public int age;
    public int strength;//武力值
    public int strategy;//谋略
    public int charm;//魅力
    public int faith;//信义
    public int ambition;//志气

    public CardPile playerCardPile;

    //初始化玩家人物
    public void PlayerCharacterInitialize()
    {
        age = 0;
        strength = 1;
        strategy = 1;
        charm = 1;
        faith = 1;
        ambition = 1;
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
