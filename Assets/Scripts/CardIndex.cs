using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;
using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
/*
 * 全部卡牌的索引
 */

public class CardIndex : MonoBehaviour
{
    public List<CardText> cardTexts = new List<CardText>();
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

        for (int i = 1; i <= maxRow; i++)
        {
            row = sheet.GetRow(i);

            newCardText = new CardText();
            newCardText.card_Name = row.GetCell(1).ToString();
            newCardText.card_Point = int.Parse(row.GetCell(3).ToString());
            newCardText.card_Description = row.GetCell(4).ToString();
            string colorString = row.GetCell(2).ToString();
            switch (colorString)
            {
                case "红":
                    newCardText.cardColor = CardColor.RED;
                    break;
                case "蓝":
                    newCardText.cardColor = CardColor.BLUE;
                    break;
                case "黄":
                    newCardText.cardColor = CardColor.YELLOW;
                    break;
                case "绿":
                    newCardText.cardColor = CardColor.GREEN;
                    break;
                case "白":
                    newCardText.cardColor = CardColor.WHITE;
                    break;
            }
            Debug.Log(row.GetCell(6));
            newCardText.cardType = Type.GetType(row.GetCell(6).ToString());

            cardTexts.Add(newCardText);
        }
    }

    public Type getCardAt(int x)//获取第x号卡牌的Type
    {
        return cardTexts[x].cardType;
    }

    // Start is called before the first frame update
    void Start()
    {
        //将卡牌的类加入索引
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
