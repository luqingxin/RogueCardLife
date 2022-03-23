using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardBack : MonoBehaviour
{
    public static GameObject selectedBack;

    void Start()
    {
        selectedBack = new GameObject();
    }

    void Update()
    {
        //已经选中卡牌后进行区域判定
        if(CardSelect.isSelected)
        {
            RaycastHit2D hit = Physics2D.Raycast(CardSelect.mousePositionInWorld, Vector2.zero);

            //第十层为“CardBack”
            if(hit.collider != null && hit.collider.gameObject.layer == 10)
            {
                ////需要一个卡牌序列
                //进行交换判定
            }

        }
    }
}
