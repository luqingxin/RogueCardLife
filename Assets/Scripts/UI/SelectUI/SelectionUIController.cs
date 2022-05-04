using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelectionUIController : MonoBehaviour
{
    public int selected_Num = 0;
    public bool isSelected = false;//是否已经选择事件选项
    public static bool isLoading = false;//是否需要加载事件数据

    private int choice_Dis = -Screen.height/10;
    public AbstractRandEvent randEvent;
    public GameObject pre_Choice;//预制体
    private GameObject choice;
    private EventLoad _load;
    public static RandEventText randEventText;
    public static bool isSelecting = false;

    public GameObject choice_Pos;//记录选项UI的位置

    //已检索并添加事件对应组件后调用
    public void IniRandEvent()
    {
        isSelected = false;
        //从物体上获取随机事件
        randEvent = transform.GetComponent<AbstractRandEvent>();

        _load.LoadEvent();

        for (int i = 0; i < randEventText._choice_num; i++)
        {
            choice = Instantiate(pre_Choice,transform);
            SetPosition(choice, i);
            randEvent.choices.Add(choice.GetComponent<EventChoice>());
            //文本索引
            //choice.transform.GetChild(0).GetComponent<Text>().text
            _load.LoadChoiceText(choice.transform.GetChild(0).GetComponent<Text>(), i);
            _load.LoadResultText(choice.transform.GetChild(1).GetComponent<Text>(), i);

            choice.GetComponent<SelectionButton>().controller = this;
            choice.GetComponent<SelectionButton>().selection_num = i;
        }
    }

    public void DeleteChoices()
    {
        randEvent = transform.GetComponent<AbstractRandEvent>();
        foreach (EventChoice temp in randEvent.choices)
        {
            Destroy(temp.gameObject);
        }
    }

    //设置选项的位置
    private void SetPosition(GameObject choice, int num)
    {
        choice.transform.position = choice_Pos.transform.position;
        choice.transform.position += new Vector3(0, num * choice_Dis, 0);
    }

    private void Start()
    {
        _load = GetComponent<EventLoad>();
        //IniRandEvent();
    }

    private void Update()
    {
        if(isSelected)
        {
            Debug.Log(selected_Num);
            randEvent.Effect(selected_Num);
            isSelected = false;
            isSelecting = false;
            DeleteChoices();
            _load.des.text = "";//清空文本
        }
        if(isLoading)
        {
            IniRandEvent();
            isLoading = false;
        }
    }
}
