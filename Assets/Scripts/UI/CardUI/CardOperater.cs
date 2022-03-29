using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//卡牌操作处理
public class CardOperater : MonoBehaviour
{
    public static float cardSpeed;
    public static GameObject selectedGameObj;//被点击的物体
    public static GameObject nullGameObj;//为避免报错设定的物体
    public static bool isShowcased;//是否进入卡牌详情界面
    public static bool isSelected;//是否已选择卡牌
    public static bool isDraging;//是否正在拖动卡牌

    public List<AbstractCard> cards;//当前卡牌的序列
    public static int formalCardIndex;//拖动卡牌的序号
    public static int targetCardIndex;//目标卡牌的序号

    private CardIndex index;

    public GameObject showcase;//卡牌详情
    private GameObject showcase_pic;
    private GameObject showcase_frame;

    private void Start()
    {
        cardSpeed = 2.8f * Time.deltaTime;
        
        selectedGameObj = new GameObject();
        nullGameObj = selectedGameObj;

        showcase_frame = showcase.transform.GetChild(1).gameObject;
        showcase_pic = showcase.transform.GetChild(0).gameObject;
        index = new CardIndex();

        isShowcased = false;
        isSelected = false;
    }

    private void Update()
    {
        MouseRightButton();
        ShowCase();
    }

    private void ShowCase()
    {
        if (isShowcased)
        {
            showcase.SetActive(true);
            string selectedCardName;
            selectedCardName = "Cards/" + selectedGameObj.name;

            Sprite _cardPic = Resources.Load<Sprite>(selectedCardName);
            showcase_frame.GetComponent<Image>().sprite = _cardPic;
        }
        else
        {
            showcase.SetActive(false);
        }
    }

    private void MouseRightButton()
    {
        //非拖动状态
        if(!isDraging)
        {
            //抬起右键
            if(Input.GetMouseButtonUp(1))
            {
                if(!isShowcased && isSelected)
                {
                    isShowcased = true;
                }
                else if(isShowcased)
                {
                    isShowcased = false;
                }
            }
        }
    }

}
