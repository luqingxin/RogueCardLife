using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * 获取志气的动作
 */
public class GainAmbitionAction : AbstractGameAction
{

    public GainAmbitionAction(AbstractCharacter s, AbstractCharacter t, AbstractGameRun g, int n) : base(s, t, g, n) { }
    public override void Effect()
    {
        target.GainAmbition(magicNum);
    }

}
