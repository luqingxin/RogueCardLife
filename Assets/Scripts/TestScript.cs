using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript : MonoBehaviour
{

    public GameObject testObject;

    public void test1()
    {
        Instantiate(testObject);
        
    }

    // Start is called before the first frame update
    void Start()
    {
        test1();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
