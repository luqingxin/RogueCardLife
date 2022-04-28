using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//复制玩家卡组到抽牌堆
public class PlayerPileToDraw : AbstractGameAction
{
    bool ptdDone;

    public PlayerPileToDraw(AbstractGameRun g)
    {
        gameRun = g;
        ptdDone = false;
    }

    public override void Effect()
    {
        if (ptdDone == false)
        {
            CardPile playerCardPile = gameRun.playerCharacter.playerCardPile;
            for (int i = 0; i < playerCardPile.cards.Count; i++)
            {
                GameObject x = UnityEngine.Object.Instantiate(playerCardPile.cards[i].gameObject, gameRun.cardCanvas.transform);
                gameRun.gameState.drawPile.AddCard(x.GetComponent<AbstractCard>());
            }
            ptdDone = true;
        }
        isDone = true;
        List<AbstractCard> cards = gameRun.gameState.drawPile.cards;
        for (int i=0;i< cards.Count; i++)
        {
            bool a = gameRun.cardAnimationController.BackDraw(cards[i].gameObject);
            isDone &= a;
        }
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
