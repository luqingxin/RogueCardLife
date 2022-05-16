using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnegyText : MonoBehaviour
{
    Text enegyText;
    Text maxEnegyText;


    // Start is called before the first frame update
    void Start()
    {
        enegyText = this.transform.GetChild(0).GetComponent<Text>();
        maxEnegyText = this.transform.GetChild(1).GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        enegyText.text = AbstractGameRun.gameRun.playerCharacter.energy.ToString();
        maxEnegyText.text = AbstractGameRun.gameRun.playerCharacter.maxEnegy.ToString();
    }
}
