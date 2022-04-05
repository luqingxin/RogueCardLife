using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TestUiBall : MonoBehaviour
{

    public CardColor color;
    public Text text;
    public GameState gameState;

    // Start is called before the first frame update
    void Start()
    {
        text = this.gameObject.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        text.text = (gameState.pointOfColor[color]).ToString();
    }
}
