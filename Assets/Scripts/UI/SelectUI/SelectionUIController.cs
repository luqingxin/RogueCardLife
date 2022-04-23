using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectionUIController : MonoBehaviour
{
    public int selected_Num = 0;
    public bool isSelected = false;//是否已经选择事件选项

    public int choice_Dis = 100;
    public AbstractRandEvent randEvent;
    public GameObject pre_Choice;//预制体
    private GameObject choice;

    public GameObject choice_Pos;//记录选项UI的位置

    //已检索并添加事件对应组件后调用
    public void IniRandEvent()
    {
        isSelected = false;
        //从物体上获取随机事件
        randEvent = transform.GetComponent<AbstractRandEvent>();
        for(int i = 0; i < randEvent.choiceNum; i++)
        {
            choice = Instantiate(pre_Choice,transform);
            SetPosition(choice, i);
            randEvent.choices.Add(choice);
            //文本索引
            choice.GetComponent<SelectionButton>().controller = this;
            choice.GetComponent<SelectionButton>().selection_num = i;
        }
    }

    //设置选项的位置
    private void SetPosition(GameObject choice, int num)
    {
        choice.transform.position = choice_Pos.transform.position;
        choice.transform.position += new Vector3(0, num * choice_Dis, 0);
    }

    private void Update()
    {
        if(isSelected)
        {
            randEvent.Effect(selected_Num);
            isSelected = false;
        }
    }
}
