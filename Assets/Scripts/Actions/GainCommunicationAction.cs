using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 *获得交际
 */
public class GainCommunicationAction : AbstractGameAction
{

    public GainCommunicationAction(AbstractCharacter s, AbstractCharacter t, AbstractGameRun g, int n) : base(s, t, g, n) { }
    public override void Effect()
    {
        target.GainCommunication(magicNum);
    }

}