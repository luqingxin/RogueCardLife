using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//增加某项颜色点数的动作
public class AddColorPoint : AbstractGameAction
{

    public CardColor cardColor;
    public int point;

    public AddColorPoint(CardColor c,int x,AbstractGameRun g)
    {
        cardColor = c;
        point = x;
        gameRun = g;
    }

    public override void Effect()
    {
        gameRun.gameState.AddPointOfColor(cardColor, point);
        isDone = true;
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
