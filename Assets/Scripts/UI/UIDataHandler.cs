using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//封装UI模块中的数据处理操作
public class UIDataHandler
{

    //判断在卡牌对中的相对位置
    public static int EnterField(Vector3 centerPosition, float width, float height)
    {
        if(IsMouseEnter(centerPosition,width,height))
        {
            if (Input.mousePosition.x <= centerPosition.x)
                return 1;
            else
                return 2;
        }
        else 
            return 0;
    }

    //判断是否位于目标物体范围内
    public static bool IsMouseEnter(Vector3 centerPosition, float width, float height)
    {
        float minX = centerPosition.x - width/2;
        float maxX = centerPosition.x + width/2;
        float minY = centerPosition.y - height/2;   
        float maxY = centerPosition.y + height/2;

        if(Input.mousePosition.x >= minX && Input.mousePosition.x <= maxX)
        {
            if (Input.mousePosition.y >= minY && Input.mousePosition.y <= maxY)
                return true;
        }
        return false;
    }

    //public int 
}
