using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectionButton : MonoBehaviour
{
    public int selection_num;
    public SelectionUIController controller;
    public void Onclick()
    {
        if (GetComponent<EventChoice>().selectable)
        {
            controller.selected_Num = selection_num;
            controller.isSelected = true;
        }
        else
        {
            Debug.Log("dame");
        }
    }
}
