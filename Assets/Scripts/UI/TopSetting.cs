using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//将选中的卡牌显示到最上方
public class TopSetting : MonoBehaviour
{
    private int childNum;
    private bool topSetStatus;//记录置顶效果的状态
    public GameObject topGameObj;

    // Start is called before the first frame update
    void Start()
    {
        childNum = transform.childCount;
        topSetStatus = false;
        topGameObj = new GameObject();
    }

    // Update is called once per frame
    void Update()
    {
        if(CardSelect.isSelected && !topSetStatus)
        {
            topGameObj = CardSelect.selectedGameObj;
            topGameObj.transform.SetAsLastSibling();
            topSetStatus = true;
        }

        if(!CardSelect.isSelected && topSetStatus)
            topSetStatus = false;

        //transform.GetChild(0).SetAsLastSibling();
    }
}
