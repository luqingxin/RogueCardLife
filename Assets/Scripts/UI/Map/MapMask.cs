using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapMask : MonoBehaviour
{
    public static bool change = true;
    private bool mask = false;
    private void Update()
    {
        if (change)
        {
            gameObject.SetActive(!mask);
            mask = !mask;
            change = false;
        }
    }
}
