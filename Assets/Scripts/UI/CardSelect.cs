using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class CardSelect : MonoBehaviour
{
    GameObject selectedGameObj;//被点击的物体
    bool isSelected;
    Vector2 mousePositionOnScreen;
    Vector2 mousePositionInWorld;
    Vector2 formalPos;

    private void Start()
    {
        selectedGameObj = new GameObject();
        isSelected = false;
    }

    private void Update()
    {
        MouseFollow();
        //射线检测
        RaycastHit2D hit = Physics2D.Raycast(mousePositionInWorld, Vector2.zero);
        if(hit.collider != null)
        {
            selectedGameObj = hit.collider.gameObject.transform.parent.gameObject;
            if(selectedGameObj.layer == 8)
            {
                
            }
        }
        //点击操作处理
        if(Input.GetMouseButtonDown(0))
        {
            //第八层为“CardImg”
            if(selectedGameObj.layer == 8)
            {
                formalPos = selectedGameObj.transform.position;
                isSelected = true;
                //Debug.Log(selectedGameObj.name);
            }  
        }
        //松开鼠标操作
        if(Input.GetMouseButtonUp(0))
        {
            if(selectedGameObj.layer == 8)
            {
                isSelected = false;
                selectedGameObj.transform.position = formalPos;
            }
        }

        //跟随效果
        if(isSelected)
        {
            selectedGameObj.transform.position = mousePositionInWorld;
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
