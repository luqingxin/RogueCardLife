using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardAnimationController : MonoBehaviour
{
    private float speed = 1.5f;

    public GameObject discardObj;
    public GameObject drawObj;

    private Vector2 discardPos;
    private Vector2 drawPos;

    private void Start()
    {
        discardPos = discardObj.transform.position;
        discardPos.x += 200;
        drawPos = drawObj.transform.position;
    }

    private void Update()
    {
        if(true)
        {
            //
        }
    }

    //把卡移动到抽牌堆的动画
    public bool BackDraw(GameObject card)
    {
        card.transform.position = Vector2.Lerp(card.transform.position, drawPos, Time.deltaTime * speed);
        if (card.transform.position.Equals(drawPos))
        {
            card.transform.position = drawPos;
            return true;
        }
        return false;
    }

    //弃牌动画
    public bool Discard(GameObject card)
    {
        card.transform.position = Vector2.Lerp(card.transform.position, discardPos, Time.deltaTime*speed);
        if(card.transform.position.Equals(discardPos))
        {
            card.transform.position = discardPos;
            return true;
        }
        return false;
    }

    //抽牌动画
    public bool DrawCard(GameObject card, Vector3 targetPos)
    {
        card.transform.position = Vector2.Lerp(card.transform.position, targetPos, Time.deltaTime * speed);
        if (card.transform.position.Equals(targetPos))
        {
            card.transform.position = targetPos;
            return true;
        }
        return false;
    }
}
