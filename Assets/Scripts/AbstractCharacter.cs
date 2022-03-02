using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
 * 所有角色的抽象类
 */
public abstract class AbstractCharacter : MonoBehaviour
{
    public int age;
    public int strength;//内功
    public int move;//招式
    public int wisdom;//智谋
    public int communication;//交际
    public List<int> titleList;//角色的标签

    public void GainStrength(int x)// 获取x点内功
    {
        strength += x;
    }
    
    public void GainMove(int x)//获取x点招式
    {
        move += x;
    }
    public void GainWisdom(int x)//获取x点智谋
    {
        wisdom += x;
    }

    public void GainCommunication(int x)//获取x点交际
    {
        communication += x;
    }

}
