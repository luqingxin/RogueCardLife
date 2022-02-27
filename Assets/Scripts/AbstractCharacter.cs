using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
 * 所有角色的抽象类
 */
public abstract class AbstractCharacter : MonoBehaviour
{

    public int age;
    public int strength;//武力值
    public int wisdom;//谋略
    public int communication;//交际
    public int charm;//魅力
    public int faith;//信义
    public int courage;//勇气
    public int ambition;//志气
    public List<int> titleList;//角色的标签

    public void GainStrength(int x)// 获取x点武力
    {
        strength += x;
    }
    
    public void GainWisdom(int x)//获取x点智谋
    {
        wisdom += x;
    }

    public void GainCommunication(int x)//获取x点交际
    {
        communication += x;
    }

    public void GainCharm(int x)//获取x点魅力
    {
        charm += x;
    }

    public void GainFaith(int x)//获取x点信义
    {
        faith += x;
    }

    public void GainCourage(int x)//获取x点勇气
    {
        courage += x;
    }

    public void GainAmbition(int x)//获取x点志气
    {
        ambition += x;
    }
}
