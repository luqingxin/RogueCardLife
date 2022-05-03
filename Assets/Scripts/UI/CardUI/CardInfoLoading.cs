using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CardInfoLoading : MonoBehaviour
{
    public AbstractGameRun gameRun;

    private Text card_Name;
    private Text card_Description;
    private Text card_Point;

    private AbstractCard card;

    private bool loaded = false;

    private void Awake()
    {
        //获取对子物体Text对象的控制
        card_Name = transform.GetChild(2).GetComponent<Text>();
        card_Description = transform.GetChild(3).GetComponent<Text>();
        card_Point = transform.GetChild(4).GetComponent<Text>();
    }

    private void LateUpdate()
    {
        if (!loaded)
        {
            //Infomation(x);
            Information();
            loaded = true;
        }
    }

    public void Information()
    { 
        card = GetComponent<AbstractCard>();

        card_Name.text = card.cardName;
        card_Description.text = card.cardDescription;
        card_Point.text = card.pointNums[0].ToString();
    }
}
