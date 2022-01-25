using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
 * 获取力量的动作
 */
public class GainStrengthAction : AbstractGameAction
{
    public override void Effet()
    {
        target.GainStrength(magicNum);
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
