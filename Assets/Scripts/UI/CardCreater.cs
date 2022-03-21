using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardCreater : MonoBehaviour
{
    public GameObject prefab_red;
    public GameObject prefab_green;

    void Start()
    {
        
        Instantiate(prefab_green,new Vector3(2,-2.5f),transform.rotation,transform);
        Instantiate(prefab_red, new Vector3(0, -2.5f), transform.rotation, transform);
        Instantiate(prefab_red, new Vector3(4, -2.5f), transform.rotation, transform);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
