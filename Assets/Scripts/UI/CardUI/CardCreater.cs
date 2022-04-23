using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//生成卡牌
public class CardCreater : MonoBehaviour
{
    //卡牌预制体
    public GameObject prefab_red;
    public GameObject prefab_green;
    public GameObject prefab_blue;
    public GameObject prefab_yellow;

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
    public GameObject CreateSingleCard<T>(int type,int count) where T:AbstractCard
    {
        switch (type)
        {
            case 0:
                cardType = prefab_red;
                break;
            case 1:
                cardType = prefab_yellow;
                break;
            case 2:
                cardType = prefab_blue;
                break;
            case 3:
                cardType = prefab_green;
                break;
        }
        newCard = Instantiate(cardType, new Vector3(0, 0, 0), transform.rotation, transform);
        return newCard;
    }
}
