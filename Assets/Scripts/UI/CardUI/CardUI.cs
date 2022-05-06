using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

//卡牌按钮功能
public class CardUI : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler,IBeginDragHandler,IDragHandler,IEndDragHandler
{
    public int indexInList;//在当前场景中的顺序

    //public Canvas canvas;
    RectTransform rectTransform;
    Vector2 formalPos;
    Vector2 targetPos;

    Camera _camera;
    bool state = false;
    RectTransform canvasRectTransform;

    void Start()
    {
        formalPos = transform.position;
        PositionTranslate();
    }

    private void Update()
    {
    }

    //转换坐标
    private void PositionTranslate()
    {
        rectTransform = transform as RectTransform;
        //_camera = canvas.GetComponent<Camera>();
        //canvasRectTransform = canvas.transform as RectTransform;
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        if(!CardOperater.isShowcased && !CardOperater.isDraging)
        {
            CardOperater.selectedGameObj = gameObject;
            CardOperater.isSelected = true;
        }
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        if(!CardOperater.isShowcased && !CardOperater.isDraging)
        {
            CardOperater.isSelected = false;
            CardOperater.selectedGameObj = CardOperater.nullGameObj;
        }
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        if (this.gameObject.GetComponent<AbstractCard>().isInHand() == false)
        {
            return;
        }
        formalPos = transform.position;
        transform.position = eventData.position;
        GetComponent<CanvasGroup>().blocksRaycasts = false;
        CardOperater.isDraging = true;
    }

    public void OnDrag(PointerEventData eventData)
    {
        if (this.gameObject.GetComponent<AbstractCard>().isInHand() == false)
        {
            return;
        }
        transform.position = eventData.position;
        if (eventData.pointerCurrentRaycast.gameObject != null)
        {
            if (eventData.pointerCurrentRaycast.gameObject.layer == 9)
            {
                CardOperater.formalCardIndex = indexInList;
                CardUI cardUI = eventData.pointerCurrentRaycast.gameObject.GetComponent<CardUI>();
                if(cardUI != null)
                {
                    CardOperater.targetCardIndex = cardUI.indexInList;
                }
            }
        }
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        if (this.gameObject.GetComponent<AbstractCard>().isInHand() == false)
        {
            return;
        }
        if (eventData.pointerCurrentRaycast.gameObject != null)
        {
            if (eventData.pointerCurrentRaycast.gameObject.layer == 9)
            {
                targetPos = eventData.pointerCurrentRaycast.gameObject.transform.position;
                eventData.pointerCurrentRaycast.gameObject.transform.position = formalPos;
                formalPos = targetPos;
                AbstractCard cardA = this.GetComponent<AbstractCard>();//找到两张卡的脚本
                AbstractCard cardB = eventData.pointerCurrentRaycast.gameObject.GetComponent<AbstractCard>();
                //Debug.Log(cardA.cardDescription);
                //Debug.Log(cardB.cardDescription);
                cardA.AddActionToButtom(new SwapCardAction(cardB, cardA,cardA.gameRun));//逻辑上交换这两张卡
            }
        }
        transform.position = formalPos;
        GetComponent<CanvasGroup>().blocksRaycasts = true;
        CardOperater.isDraging=false;

        CardOperater.formalCardIndex = -1;
        CardOperater.targetCardIndex = -1;
    }

    //重置卡牌位置
    private void Relocate()
    {
        
    }
}
