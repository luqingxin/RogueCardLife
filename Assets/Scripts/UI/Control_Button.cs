using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Control_Button : MonoBehaviour
{
    public GameObject targetObj;
    private bool selected = false;
    private int add = 0;

    public void OnClick()
    {
        selected = !selected;
        targetObj.GetComponent<Canvas>().enabled = !targetObj.GetComponent<Canvas>().enabled;
        if (selected)
            add = -2;
        else
            add = 2;

        transform.position = new Vector3(transform.position.x, transform.position.y+add, transform.position.z);
    }
}
