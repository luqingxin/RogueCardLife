using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class CardFrame : MonoBehaviour
{
    public GameObject lightFrame;
    public GameObject pic;
    private void OnMouseEnter()
    {
        if(CardSelect.isSelected == false && CardSelect.isShowcased == false)
            lightFrame.SetActive(true);
    }
    private void OnMouseExit()
    {
        if (CardSelect.isSelected == false && CardSelect.isShowcased == false)
            lightFrame.SetActive(false);
    }
    private void Update()
    {
        if (CardSelect.isShowcased)
            lightFrame.SetActive(false);
    }
    public void loadCardPic(Sprite cardPic)
    {
        pic.GetComponent<Image>().sprite = cardPic;
    }
}
