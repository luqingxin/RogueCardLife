using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateParticle : MonoBehaviour
{
    private string path = "/Prefabs/AnimationPrefabs/";
    private string name = "";

    private GameObject pre;

    public void Create(CardColor color,Vector3 pos)
    {
        switch (color)
        {
            case CardColor.RED:
                name = "RedParticle";
                break;
            case CardColor.GREEN:
                name = "GreenParticle";
                break;
            case CardColor.BLUE:
                name = "BlueParticle";
                break;
            case CardColor.YELLOW:
                name = "YellowParticle";
                break;
            case CardColor.WHITE:
                name = "WhiteParticle";
                break;
            default:
                return;
        }

        pre = (GameObject)Resources.Load(path + name);
        pre = Instantiate(pre);
        pre.transform.position = Camera.main.ScreenToWorldPoint(pos);
    }
}
