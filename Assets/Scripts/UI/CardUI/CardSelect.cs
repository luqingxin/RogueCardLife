﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardSelect : MonoBehaviour
{
    private float cardSpeed;
    public static GameObject selectedGameObj;//被点击的物体
    public static GameObject nullGameObj;//为避免报错设定的物体
    public static bool isShowcased;//是否进入卡牌详情界面
    public static bool isSelected;
    Vector3 mousePositionOnScreen;
    public static Vector3 mousePositionInWorld;
    public static Vector3 formalPos;
    public static List<AbstractCard> cards;//当前卡牌的序列

    public GameObject showcase;
    private GameObject showcase_pic;
    private GameObject showcase_frame;

    private void Start()
    {
        cardSpeed = 2.8f * Time.deltaTime;

        selectedGameObj = new GameObject();
        nullGameObj = selectedGameObj;
        showcase_pic = showcase.transform.GetChild(0).gameObject;
        showcase_frame = showcase.transform.GetChild(2).gameObject;

        isShowcased = false;
        isSelected = false;
    }

    [System.Obsolete]
    private void Update()
    {
        MouseFollow();
        
        MouseRightButton();
        MouseLeftButton();

    }

    private void MouseRightButton()
    {
        if (Input.GetMouseButtonDown(1))
        {
            RaycastHit2D hit = Physics2D.Raycast(mousePositionInWorld, Vector2.zero);

            if (hit.collider != null && !isShowcased)
            {
                selectedGameObj = hit.collider.gameObject;
                formalPos = hit.collider.transform.position;
                isShowcased = true;
                //卡牌展示界面
                showcase.SetActive(true);
                //showcase_pic.SetActive(true);
                string selectedCardName;
                //selectedCardNum = selectedGameObj.GetComponent<AbstractCard>().cardNum;//获取卡牌序号
                selectedCardName = selectedGameObj.name;

                Sprite _cardPic = Resources.Load<Sprite>(selectedCardName);
                showcase_frame.GetComponent<SpriteRenderer>().sprite = _cardPic;

            }
            else if (isShowcased)
            {
                isShowcased = false;
                showcase.SetActive(false);
            }
        }
    }

    private void MouseLeftButton()
    {
        //判断是否进入卡牌展示界面
        if (isShowcased)
        {

        }
        else
        {
            //点击操作处理
            if (Input.GetMouseButtonDown(0))
            {
                //射线检测
                RaycastHit2D hit = Physics2D.Raycast(mousePositionInWorld, Vector2.zero);

                //当未选中卡牌且射线检测到物体，更新已选卡牌
                if (hit.collider != null && !isSelected)
                {
                    selectedGameObj = hit.collider.gameObject;
                }

                //第八层为“CardImg”
                if (selectedGameObj.layer == 8)
                {
                    formalPos = selectedGameObj.transform.position;
                    isSelected = true;
                }
            }
            //松开鼠标操作
            if (Input.GetMouseButtonUp(0))
            {
                if (selectedGameObj.layer == 8)
                {
                    isSelected = false;
                    //selectedGameObj.transform.position = formalPos;
                    //selectedGameObj = nullGameObj;
                }
            }
            //跟随效果、归位效果
            if (isSelected)
            {
                selectedGameObj.transform.position = new Vector3(Mathf.Lerp(selectedGameObj.transform.position.x, mousePositionInWorld.x, cardSpeed), Mathf.Lerp(selectedGameObj.transform.position.y, mousePositionInWorld.y, cardSpeed), 0);
            }
            else
            {
                if (selectedGameObj.transform.position == formalPos)
                {
                    selectedGameObj = nullGameObj;
                }
                else
                {
                    selectedGameObj.transform.position = new Vector3(Mathf.Lerp(selectedGameObj.transform.position.x, formalPos.x, 1.5f * cardSpeed), Mathf.Lerp(selectedGameObj.transform.position.y, formalPos.y, cardSpeed), 0);
                }
            }
        }
    }

    private void MouseFollow()
    {
        //获取鼠标在场景中坐标
        mousePositionOnScreen = Input.mousePosition;

        //将相机中的坐标转化为世界坐标
        mousePositionInWorld = Camera.main.ScreenToWorldPoint(mousePositionOnScreen);

        //物体跟随鼠标移动
        //transform.position = mousePositionInWorld;
    }
}
