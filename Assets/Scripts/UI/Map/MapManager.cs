using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//生成、管理地图单元
public class MapManager : MonoBehaviour
{
    public static int arrayX = 10;
    public static int arrayY = 6;//数组最大范围

    public static int formalMapBlockType;
    public static int formalX;
    public static int formalY;//当前坐标
    public static int targetX;
    public static int targetY;//目标坐标
    private List<MapBlock> blocks = new List<MapBlock>();
    public MapCreater creater = new MapCreater();

    private int[,] setBlocks;

    void Start()
    {
        setBlocks = new int[,]
        {
            {-1,0,0,0,1},
            {0,0,2,0,0},
            {2,0,1,1,-1},
        };

        creater.SetBlock(setBlocks,blocks);
    }

    private void Update()
    {
        
    }
}
