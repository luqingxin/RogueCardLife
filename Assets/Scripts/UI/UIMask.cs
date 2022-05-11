using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIMask : MonoBehaviour
{
    private GameObject mask;
    public static bool masking = false;

    private void Start()
    {
        mask = this.gameObject;
    }

    private void Update()
    {
        if (masking)
        {
            mask.GetComponent<Canvas>().enabled = masking;
            masking = false;
        }
    }

}
