using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateParticle
{
    private static string path = "Prefabs/AnimationPrefabs/";
    private static string name = "";

    private static GameObject pre;

    public static void Create(CardColor color,Vector3 pos)
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

        pre = Resources.Load(path + name) as GameObject;
        pre = GameObject.Instantiate(pre);
        pre.transform.position = Camera.main.ScreenToWorldPoint(pos);
    }
}
