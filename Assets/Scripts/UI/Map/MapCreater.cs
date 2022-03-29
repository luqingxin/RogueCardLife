using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapCreater : MonoBehaviour
{
    public float distance = 1.3f;//方块间距

    private int maxX;
    private int maxY;
    private float block_x;
    private float block_y;

    private GameObject ini_block_obj;
    private MapBlock ini_block;
    //存储地图方块预制体
    public GameObject block_road;
    public GameObject block_inn;
    public GameObject block_forest;
    public GameObject block_mountain;
    public GameObject block_village;
    public GameObject block_fastness;
    public GameObject block_camp;
    public GameObject block_battlefield;
    private List<GameObject> block_prefab_list;

    private void Start()
    {
        block_prefab_list = new List<GameObject>();
        block_prefab_list.Add(block_road);
        block_prefab_list.Add(block_inn);
        block_prefab_list.Add(block_forest);
        //block_prefab_list.Add(block_mountain);
        //block_prefab_list.Add(block_village);  
        //block_prefab_list.Add(block_fastness);
        //block_prefab_list.Add(block_camp);
        //block_prefab_list.Add(block_battlefield);
    }

    //初始化方块、填充List
    public void SetBlock(int[,] setblocks,List<MapBlock> blocks)
    {
        maxX = setblocks.Length/setblocks.GetLength(0);
        maxY = setblocks.GetLength(0);

        for (int i = 0; i < maxY; i++)
        {
            for (int j = 0; j < maxX; j++)
            {
                if(setblocks[i,j] >= 0)
                {
                    InstantiateMapBlock(i, j, setblocks[i, j]);
                    ini_block.transform.SetParent(transform);
                    blocks.Add(ini_block);
                }
            }
        }
    }

    //初始化方块
    private void InstantiateMapBlock(int i, int j, int type)
    {
        Debug.Log(block_prefab_list[type]);
        ini_block_obj = block_prefab_list[type];
        ini_block_obj = Instantiate(ini_block_obj);
        ini_block = ini_block_obj.GetComponent<MapBlock>();

        if (type >= 0)//该方块不为空
        {
            ini_block.x = j;
            ini_block.y = i;
            ini_block.type = type;
        }
        PositionCalculate(ini_block);
    }

    //计算位置
    private void PositionCalculate(MapBlock block)
    {
        if (maxX % 2 == 0)
            block_x = (block.x - maxX / 2) * distance + 0.5f * distance;
        else
            block_x = (block.x - maxX / 2) * distance;

        if (maxY % 2 == 0)
            block_y = (block.y - maxY / 2) * distance + 0.5f * distance;
        else
            block_y = (block.y - maxY / 2) * distance;

        block.transform.position = new Vector3(block_x, block_y, 0);
    }
}
