using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * 获取智谋
 */
public class GainWisdomAction : AbstractGameAction
{
    public GainWisdomAction(AbstractCharacter s, AbstractCharacter t, AbstractGameRun g, int n) : base(s, t, g, n) { }
    public override void Effect()
    {
        target.GainWisdom(magicNum);
    }
}
