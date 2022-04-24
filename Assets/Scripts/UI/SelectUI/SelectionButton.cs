using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectionButton : MonoBehaviour
{
    public int selection_num;
    public SelectionUIController controller;
    public void Onclick()
    {
        //GetComponent<EventChoice>().selectable = true;
        if (GetComponent<EventChoice>().selectable)
        {
            controller.selected_Num = selection_num;
            Debug.Log("您选择的是" + controller.selected_Num);
            controller.isSelected = true;
        }
        else
        {
            Debug.Log("dame");
        }
    }
}
