using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
 * 获取信义
 */
public class GainFaithAction : AbstractGameAction
{
    public GainFaithAction(AbstractCharacter s, AbstractCharacter t, AbstractGameRun g, int n) : base(s, t, g, n) { }
    public override void Effect()
    {
        target.GainFaith(magicNum);
    }
}
