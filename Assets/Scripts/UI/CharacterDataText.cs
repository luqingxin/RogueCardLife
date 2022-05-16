using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterDataText : MonoBehaviour
{
    public AbstractGameRun gameRun;
    Text nameText;
    Text[] powerText = new Text[6];
    Text moneyText;
    Text foodText;

    // Start is called before the first frame update
    void Start()
    {
        nameText = transform.GetChild(0).transform.GetChild(0).GetComponent<Text>();
        powerText[0] = transform.GetChild(2).transform.GetChild(0).transform.GetChild(1).GetComponent<Text>();
        powerText[1] = transform.GetChild(2).transform.GetChild(1).transform.GetChild(1).GetComponent<Text>();
        powerText[2] = transform.GetChild(2).transform.GetChild(2).transform.GetChild(1).GetComponent<Text>();
        powerText[3] = transform.GetChild(2).transform.GetChild(3).transform.GetChild(1).GetComponent<Text>();
        moneyText = transform.GetChild(3).transform.GetChild(0).transform.GetChild(1).GetComponent<Text>();
        foodText = transform.GetChild(3).transform.GetChild(1).transform.GetChild(1).GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        powerText[0].text = gameRun.playerCharacter.strength.ToString();
        powerText[1].text = gameRun.playerCharacter.move.ToString();
        powerText[2].text = gameRun.playerCharacter.wisdom.ToString();
        powerText[3].text = gameRun.playerCharacter.communication.ToString();
        moneyText.text = gameRun.playerCharacter.money.ToString();
        foodText.text = gameRun.playerCharacter.food.ToString();
    }
}
