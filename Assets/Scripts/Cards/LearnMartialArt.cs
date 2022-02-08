using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//卡牌习武，效果武力+3
public class LearnMartialArt : AbstractCard
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public override void Effect()
    {
        addActionToButtom(new GainStrengthAction(gameRun.playerCharacter,gameRun.playerCharacter,gameRun,magicNumber1));//获得力量
    }
}
