using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[System.Serializable]
public class RandEventText : ScriptableObject
{
    public int _index;//编号
    public string _name;
    public string _description;
    public List<int> _geos;
    public int _choice_num;
    public Type randEventType;

    public List<string> _choices;
    public List<string> _choices_result;//结果的奖励缩略显示
    public List<string> _choices_result_text;//结果的文本内容
}
