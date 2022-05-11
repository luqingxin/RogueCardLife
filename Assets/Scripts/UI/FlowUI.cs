using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FlowUI : MonoBehaviour
{
    public Sprite greyFlow;
    public Sprite orangeFlow;
    public Camera camera;
    private GameObject flow0;
    private GameObject flow1;
    private GameObject flow2;
    private Vector3 dis = new Vector3(0,0.1f,0);

    private int previousFlowNum = 0;
    public static int flowNum = 0;

    private void Start()
    {
        flow0 = transform.GetChild(0).gameObject;
        flow1 = transform.GetChild(1).gameObject;
        flow2 = transform.GetChild(2).gameObject;
    }

    private void Update()
    {
        if(flowNum!=previousFlowNum)
        {
            ActiveFlow(flowNum);
            previousFlowNum = flowNum;
            flowNum = (flowNum + 1) % 3;
        }
    }

    private void ActiveFlow(int i)
    {
        switch (i)
        {
            case 0:
                flow0.GetComponent<Image>().sprite = orangeFlow;
                flow0.transform.position += dis;
                flow2.GetComponent<Image>().sprite = greyFlow;
                flow2.transform.position -= dis;
                break;
            case 1:
                flow0.GetComponent<Image>().sprite = greyFlow;
                flow0.transform.position -= dis;
                flow1.GetComponent<Image>().sprite = orangeFlow;
                flow1.transform.position += dis;
                break;
            case 2:
                flow1.GetComponent <Image>().sprite = greyFlow;
                flow1.transform.position -= dis;
                flow2.GetComponent<Image>().sprite = orangeFlow;
                flow2.transform.position += dis;
                break;
        }

    }
}
