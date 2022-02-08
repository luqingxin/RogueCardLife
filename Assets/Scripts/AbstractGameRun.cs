using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * 一局游戏的抽象类，包含一局游戏的各种对象信息
 */

public class AbstractGameRun : MonoBehaviour
{
    public GameActionManager gameActionManager;
    public GameState gameState;
    public PlayerCharacter playerCharacter;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
