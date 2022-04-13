using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardPositions : MonoBehaviour
{
    public static List<Vector2> positions;

    void Start()
    {
        positions = new List<Vector2> ();
        GetPos();
    }

    public void GetPos()
    {
        int i = transform.childCount;
        for (int j = 0; j < i; j++)
        {
            positions.Add(transform.GetChild(j).position);
        }
    }
}
