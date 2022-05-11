using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//三选一卡牌的动作
public class ChooseCard : AbstractGameAction
{
    CardText[] cardText = new CardText[5];
    CardCreater cardCreater;
    AbstractCard[] card = new AbstractCard[5];
    bool isChooseDone = false;
    AbstractCard choosedCard = null;
    bool isIniDone = false;

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
        //生成三张牌到界面上
        if (isIniDone == false)
        {
            for (int i = 0; i < 3; i++)
            {
                card[i] = cardCreater.CreateSingleCard(cardText[i].cardType);
                card[i].transform.position = CardRewardPosition.positions[i];
                card[i].GetComponent<CardUI>().enabled = false;
                card[i].gameObject.AddComponent<ChoosingCard>();
            }
            isIniDone = true;
        }
        //判断是否有牌被点击
        if (isChooseDone == false)
        {
            for (int i = 0; i < 3; i++)
            {
                ChoosingCard x = card[i].GetComponent<ChoosingCard>();
                if (x != null)
                {
                    if (x.isChoosed == true)
                    {
                        isChooseDone = true;
                        choosedCard = card[i];
                        GameObject.Destroy(card[i].GetComponent<ChoosingCard>());
                        card[i].gameObject.GetComponent<CardUI>().enabled = true;
                        for (int j = 0; j < 3; j++)
                        {
                            if (i != j)
                            {
                                GameObject.Destroy(card[i].gameObject);
                            }
                        }
                        if (gameRun.gameState.isInBattle == true)
                        {
                            gameRun.gameState.drawPile.AddCard(card[i]);
                        }
                        else
                        {
                            gameRun.playerCharacter.playerCardPile.AddCard(card[i]);
                        }
                        break;
                    }
                }
            }
        }
        //执行动画
        if(choosedCard != null)
        {
            if(gameRun.gameState.isInBattle == true)
            {
                isDone = gameRun.cardAnimationController.BackDraw(choosedCard.gameObject);
            }
            else
            {
                choosedCard.gameObject.transform.position = new Vector3(-640, -360, 0);
                isDone = true;
            }
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
