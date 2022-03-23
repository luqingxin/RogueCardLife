using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIController : MonoBehaviour
{
    public GameObject map_controller;
    public GameObject card_controller;
    public static bool map_active = false;
    public static bool card_active = false;

    void Start()
    {
        
    }

    //改变UI的使用情况
    public void ChangeUI()
    {
        if (map_active)
            map_controller.SetActive(true) ;

    }
}
