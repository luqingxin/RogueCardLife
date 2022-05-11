using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeckPosition : MonoBehaviour
{
    public static Vector2 position;

    // Start is called before the first frame update
    void Start()
    {
        position = this.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
