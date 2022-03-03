using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
 * 获取力量的动作
 */
public class GainStrengthAction : AbstractGameAction
{

    public GainStrengthAction(AbstractCharacter s, AbstractCharacter t, AbstractGameRun g, int n) : base(s, t, g, n) { }
    public override void Effect()
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
