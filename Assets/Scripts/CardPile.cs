using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
 * 牌堆类
 */
public class CardPile : MonoBehaviour
{
    public List<AbstractCard> cards;

    public static CardPile GetInitialRandCardPile()
    {
        
        return null;
    }

    public void ShuffleCards()//给牌堆洗牌
    {
        System.Random random = new System.Random();
        int n = cards.Count;
        for(int i = 0; i < n; i++)
        {
            int j = random.Next(0,n-1);
            AbstractCard temp = cards[j];
            cards[j] = cards[i];
            cards[i] = temp;
        }
    }

    public void AddCard(AbstractCard x)//在牌堆中加入一张
    {
        cards.Add(x);
    }

    public void DeleteCard(AbstractCard x)//在牌堆中删除一张
    {
        cards.Remove(x);
    }

    public AbstractCard DrawCard()//抽一张牌
    {
        if(cards.Count == 0)
        {
            return null;
        }
        AbstractCard x = cards[0];
        cards.RemoveAt(0);
        return x;
    }

    // Start is called before the first frame update
    void Start()
    {
        cards = new List<AbstractCard>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
