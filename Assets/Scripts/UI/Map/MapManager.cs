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
    public AbstractGameRun gameRun;

    private int[,] setBlocks;


    public Vector3Int getMapPosition(Vector3 position)
    {
        int block_x, block_y;
        if (creater.maxX % 2 == 0)
            block_x = (int)((position.x - 0.5f * creater.distance) / creater.distance) + creater.maxX / 2;
        else
            block_x = (int)((position.x ) / creater.distance) + creater.maxX / 2;
        if (creater.maxY % 2 == 0)
            block_y = (int)((position.y - 0.5f * creater.distance) / creater.distance) + creater.maxY / 2;
        else
            block_y = (int)((position.y) / creater.distance) + creater.maxX / 2;
        return new Vector3Int(block_x, block_y,0);
    }

    public Vector3 getFloatPosition(Vector3Int position)
    {
        
        float block_x, block_y;
        if (creater.maxX % 2 == 0)
            block_x = (position.x - creater.maxX / 2) * creater.distance + 0.5f *  creater.distance;
        else
            block_x = (position.x - creater.maxX / 2) * creater.distance;

        if (creater.maxY % 2 == 0)
            block_y = (position.y - creater.maxY / 2) * creater.distance + 0.5f * creater.distance;
        else
            block_y = (position.y - creater.maxY / 2) * creater.distance;
        Debug.Log(block_x);
        Debug.Log(position);
        return new Vector3(block_x, block_y,0);
    }

    //获取xy位置的格子
    public MapBlock GetMapBlockAt(int x,int y)
    {
        for(int i = 0; i < blocks.Count; i++)
        {
            if(blocks[i].x == x && blocks[i].y == y)
            {
                return blocks[i];
            }
        }
        return null;
    }

    void Start()
    {
        setBlocks = new int[,]
        {
            {-1,0,0,0,1},
            {0,0,2,0,0},
            {2,0,1,1,-1},
        };
        creater.gameRun = gameRun;
        gameRun.playerCharacter.transform.SetParent(transform);
        creater.SetBlock(setBlocks,blocks);
    }

    private void Update()
    {
        
    }
}
