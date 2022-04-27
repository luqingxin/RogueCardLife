using System;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;

public class RandEventIndex : MonoBehaviour
{
    public List<RandEventText> texts;
    public RandEventText text;

    public int maxRow;//行数

    private string filePath;//文件保存路径
    private string fileName;
    private HSSFWorkbook wk;
    private FileStream fs;

    private ISheet sheet;
    private IRow row;
    private ICell cell;

    private void Awake()
    {
        filePath = Application.dataPath + "/Data/";
        fileName = "事件.xls";
        texts = new List<RandEventText>();
        LoadExcel();
        //this.gameObject.SetActive(false);
    }

    void Start()
    {

    }

    private void LoadExcel()
    {
        fs = File.OpenRead(filePath+fileName);
        wk = new HSSFWorkbook(fs);
        sheet = wk.GetSheetAt(0);
        
        for(int j = 1; j <= maxRow; j++)
        {
            text = new RandEventText();
            text._choices = new List<string>();
            text._choices_result = new List<string>();
            text._choices_result_text = new List<string>();
            text._geos = new List<int>();

            row = sheet.GetRow(j);
            {
                text.randEventType = Type.GetType(row.GetCell(1).ToString());
                text._name = row.GetCell(2).ToString();
                text._description = row.GetCell(3).ToString();
                LoadInt(row.GetCell(4).ToString(),text._geos);//读取地图类型
                text._choice_num = int.Parse(row.GetCell(6).ToString());

                for(int k = 0; k < text._choice_num; k++)
                {
                    text._choices.Add(row.GetCell(7+4*k).ToString());
                    text._choices_result.Add(row.GetCell(9+4*k).ToString());
                    text._choices_result_text.Add(row.GetCell(10+4*k).ToString());
                }
                texts.Add(text);
            }
        }

    }

    private void LoadInt(string s,List<int> geos)
    {
        for(int i = 0; i < s.Length; i++)
        {
            geos.Add(Convert.ToInt32(s[i])-48);
        }
    }
}
