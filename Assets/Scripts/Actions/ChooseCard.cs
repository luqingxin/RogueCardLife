using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//三选一卡牌的动作
public class ChooseCard : AbstractGameAction
{
    CardText[] cardText = new CardText[5];
    CardCreater cardCreater;
    AbstractCard[] card = new AbstractCard[5];

    public ChooseCard(AbstractGameRun g,CardText a,CardText b,CardText c)
    {
        gameRun = g;
        cardCreater = gameRun.cardCanvas.GetComponent<CardCreater>();
        cardText[0] = a;
        cardText[1] = b;
        cardText[2] = c;
    }

    public override void Effect()
    {
        for(int i = 0; i < 2; i++)
        {
            card[i] = cardCreater.CreateSingleCard(cardText[i].cardType);
            card[i].transform.position = CardRewardPosition.positions[i];
            GameObject.Destroy(card[i].gameObject.GetComponent<CardUI>());
            //card[i].gameObject.AddComponent<>();
        }
        if (true)
        {
            
            isDone = true;
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
