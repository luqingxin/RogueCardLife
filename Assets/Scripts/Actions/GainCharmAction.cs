using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * 获取魅力的动作
 */
public class GainCharmAction : AbstractGameAction
{

    public GainCharmAction(AbstractCharacter s, AbstractCharacter t, AbstractGameRun g, int n) : base(s, t, g, n) { }
    public override void Effect()
    {
        target.GainCharm(magicNum);
    }

}
