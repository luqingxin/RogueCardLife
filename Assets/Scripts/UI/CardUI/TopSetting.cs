using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//将选中的卡牌显示到最上方
public class TopSetting : MonoBehaviour
{
    private int childNum;
    private bool topSetStatus;//记录置顶效果的状态
    private GameObject topGameObj;
    private GameObject otherObj;

    // Start is called before the first frame update
    void Start()
    {
        childNum = transform.childCount;
        topSetStatus = false;
        topGameObj = new GameObject();
        otherObj = GetComponent<CardOperater>().showcase.transform.parent.gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        //选中物体但并未置顶
        if(CardOperater.isSelected && !topSetStatus)
        {
            topGameObj = CardOperater.selectedGameObj;
            topGameObj.transform.SetAsLastSibling();
            otherObj.transform.SetAsLastSibling();
            topSetStatus = true;
        }

        //未选中物体时重置状态
        if(!CardOperater.isSelected && topSetStatus)
            topSetStatus = false;

    }
}
