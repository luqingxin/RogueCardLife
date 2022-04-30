using System;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;

public class CardInfoIndex : MonoBehaviour
{
    public static List<CardText> cardTexts = new List<CardText>();
    public CardText newCardText;

    public int maxRow;

    private string filePath;//文件保存路径
    private string fileName;
    private HSSFWorkbook wk;
    private FileStream fs;

    private ISheet sheet;
    private IRow row;

    private void Awake()
    {
        filePath = Application.dataPath + "/Data/";
        fileName = "卡牌.xls";
        
        LoadExcel();
        //this.gameObject.SetActive(false);
    }

    private void LoadExcel()
    {
        fs = File.OpenRead(filePath + fileName);
        wk = new HSSFWorkbook(fs);
        sheet = wk.GetSheetAt(0);

        for(int i = 0; i < maxRow; i++)
        {
            row = sheet.GetRow(i);

            newCardText = new CardText();
            newCardText.card_Name = row.GetCell(1).ToString();
            newCardText.card_Point = row.GetCell(3).ToString();
            newCardText.card_Description = row.GetCell(4).ToString();

            cardTexts.Add(newCardText);
        }
    }
}
