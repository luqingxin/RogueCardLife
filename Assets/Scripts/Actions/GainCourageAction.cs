using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
 *获取勇气 
 */

public class GainCourageAction : AbstractGameAction
{
    public GainCourageAction(AbstractCharacter s, AbstractCharacter t, AbstractGameRun g, int n) : base(s, t, g, n) { }
    public override void Effect()
    {
        target.GainCourage(magicNum);
    }
}

