using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterSlider : MonoBehaviour
{
    private Slider slider;
    private Text num;
    public int sliderOrderNum;

    private void Awake()
    {
        num = transform.GetChild(1).GetComponent<Text>();
        slider = transform.GetChild(2).GetComponent<Slider>();
    }

    private void Update()
    {
        DataUpdate();
    }

    public void DataUpdate()
    {
        switch (sliderOrderNum)
        {
            case 0:
                num.text = AbstractGameRun.gameRun.playerCharacter.strength.ToString();
                break;
            case 1:
                num.text = AbstractGameRun.gameRun.playerCharacter.move.ToString();
                break;
            case 2:
                num.text = AbstractGameRun.gameRun.playerCharacter.wisdom.ToString();
                break;
            case 3:
                num.text = AbstractGameRun.gameRun.playerCharacter.communication.ToString();
                break;
        }
    }
}
