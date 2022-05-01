using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterSlider : MonoBehaviour
{
    private Slider slider;
    private Text num;

    private void Awake()
    {
        num = transform.GetChild(1).GetComponent<Text>();
        slider = transform.GetChild(2).GetComponent<Slider>();
    }

    public void DataUpdate()
    {
        //
    }
}
