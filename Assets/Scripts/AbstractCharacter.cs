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
    public int strategy;//谋略
    public int charm;//魅力
    public int faith;//信义
    public int ambition;//志气

    public void GainStrength(int x)// 获取x点武力
    {
        this.strength += x;
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
