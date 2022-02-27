using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//卡牌习武，效果武力+3
public class LearnMartialArt : AbstractCard
{
    public override void Effect()
    {
        addActionToButtom(new GainStrengthAction(gameRun.playerCharacter,gameRun.playerCharacter,gameRun,magicNumber1));//获得力量
    }
}
