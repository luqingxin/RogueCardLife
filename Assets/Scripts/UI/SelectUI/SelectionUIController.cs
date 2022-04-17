using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectionUIController : MonoBehaviour
{
    public int choice_Dis = 100;
    public AbstractRandEvent randEvent;
    public GameObject pre_Choice;
    private GameObject choice;

    public GameObject choice_Pos;//记录选项UI的位置

    //已检索并添加卡牌对应组件后调用
    public void IniRandEvent()
    {
        randEvent = transform.GetComponent<AbstractRandEvent>();
        for(int i = 0; i < randEvent.choiceNum; i++)
        {
            choice = Instantiate(pre_Choice,transform);
            SetPosition(choice, i);
            randEvent.choices.Add(choice);
            choice.GetComponent<SelectionButton>().selection_num = i;
        }
    }

    //设置选项的位置
    private void SetPosition(GameObject choice, int num)
    {
        choice.transform.position = choice_Pos.transform.position;
        choice.transform.position += new Vector3(0, num * choice_Dis, 0);
    }

}
