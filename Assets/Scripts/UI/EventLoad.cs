using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EventLoad : MonoBehaviour
{
    public static int loading_event = 2;

    private RandEventIndex index;
    public Text name;
    public Text des;

    void Start()
    {
        index = transform.parent.GetComponent<RandEventIndex>();
    }

    public void LoadEvent()
    {
        name.text = index.texts[loading_event]._name;
        des.text = index.texts[loading_event]._description;
    }

    public void LoadChoiceText(Text text,int i)
    {
       // Debug.Log(loading_event);
        //Debug.Log(i);
        //Debug.Log(index.texts[loading_event]._choices.Count);
        text.text = index.texts[loading_event]._choices[i];
    }

    public void LoadResult(int i)
    {
        des.text = index.texts[loading_event]._choices_result_text[i];
    }
}
