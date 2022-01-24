using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class CardFrame : MonoBehaviour
{
    public GameObject frame;
    private void OnMouseEnter()
    {
        if(CardSelect.isSelected == false && CardSelect.isShowcased == false)
            frame.SetActive(true);
    }
    private void OnMouseExit()
    {
        if (CardSelect.isSelected == false && CardSelect.isShowcased == false)
            frame.SetActive(false);
    }
    private void Update()
    {
        if (CardSelect.isShowcased)
            frame.SetActive(false);
    }
}
