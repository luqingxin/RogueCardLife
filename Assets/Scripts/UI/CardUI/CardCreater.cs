using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

//生成卡牌
public class CardCreater : MonoBehaviour
{
    //卡牌预制体
    public GameObject prefab_red;
    public GameObject prefab_green;
    public GameObject prefab_blue;
    public GameObject prefab_yellow;
    public GameObject prefab_white;

    //卡牌对
    public GameObject pair;
    public int cardNum = 12;//手牌上限

    private GameObject cardType;
    private GameObject newCard;
    private Vector3 location;

    void Start()
    {
        CreateCardPairs();
        
    }

    //创建卡牌对
    private void CreateCardPairs()
    {
        int column;
        if(cardNum %4 == 0)
        {
            column = cardNum / 4;
        }
        else
        {
            column = ( cardNum + 2 )/ 4;
        }

        for(int i = 0; i < 2; i++)
        {
            for(int j = 0; j < column; j++)
            {
                pair = new GameObject();
                pair.transform.parent = transform;
                
                
            }
        }

    }

    //创建卡牌
    public AbstractCard CreateSingleCard(Type t)
    {
        cardType = prefab_red;
        newCard = Instantiate(cardType, new Vector3(0, 0, 0), transform.rotation, transform);
        newCard.AddComponent(t);
        AbstractCard x = newCard.GetComponent<AbstractCard>();
        Image image = newCard.GetComponent<Image>();
        //卡牌生成后，再确定脚本中指定的颜色
        switch (x.cardColors[0])
        {
            case CardColor.BLUE:
                image.sprite = prefab_blue.GetComponent<Image>().sprite;
                break;
            case CardColor.GREEN:
                image.sprite = prefab_green.GetComponent<Image>().sprite;
                break;
            case CardColor.RED:
                image.sprite = prefab_red.GetComponent<Image>().sprite;
                break;
            case CardColor.WHITE:
                image.sprite = prefab_white.GetComponent<Image>().sprite;
                break;
            case CardColor.YELLOW:
                image.sprite = prefab_yellow.GetComponent<Image>().sprite;
                break;
        }
        return newCard.GetComponent<AbstractCard>();
    }
}
