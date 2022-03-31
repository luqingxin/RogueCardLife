using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardAnimationController : MonoBehaviour
{
    private float speed = 1.5f;

    public bool draw = false;
    public bool discard = false;

    public GameObject discardObj;
    public GameObject drawObj;
    public GameObject card;

    private Vector2 discardPos;
    private Vector2 drawPos;

    private void Start()
    {
        discardPos = discardObj.transform.position;
        drawPos = drawObj.transform.position;
    }

    private void Update()
    {
        if(draw)
        {
            //DrawCard();
        }
    }

    //弃牌动画
    public void Discard()
    {
        card.transform.position = Vector2.Lerp(card.transform.position, discardPos, Time.deltaTime*speed);
        if(card.transform.position.Equals(discardPos))
        {

        }
    }

    //抽牌动画
    public void DrawCard()
    {
        card.transform.position = Vector2.Lerp(card.transform.position, drawPos, Time.deltaTime * speed);
        if (card.transform.position.Equals(drawPos))
        {

        }
    }
}
