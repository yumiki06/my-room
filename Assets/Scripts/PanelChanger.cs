﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//矢印をクリックしたら、特定のPanelを表示する
public class PanelChanger : MonoBehaviour
{
    string currentPanelStr = "Panel0";

    public void OnRightArrow()
    {
        //もし現在地がPanel0だったら
        if (currentPanelStr == "Panel0")
        {
            //Panel1を表示する（-1000,0,0）
            this.transform.localPosition = new Vector2(-1000, 0);
            currentPanelStr = "Panel1";
        }
        else if (currentPanelStr == "Panel1")
        {
            this.transform.localPosition = new Vector2(-2000, 0);
            currentPanelStr = "Panel2";
        }
        else if (currentPanelStr == "Panel2")
        {
            this.transform.localPosition = new Vector2(-3000, 0);
            currentPanelStr = "Panel3";
        }
        else
        {
            this.transform.localPosition = new Vector2(0, 0);
            currentPanelStr = "Panel0";
        }
    }

    public void OnLeftArrow()
    {
        //もし現在地がPanel0だったら
        if (currentPanelStr == "Panel0")
        {
            //Panel3を表示する（-1000,0,0）
            this.transform.localPosition = new Vector2(-3000, 0);
            currentPanelStr = "Panel3";
        }
        else if (currentPanelStr == "Panel3")
        {
            this.transform.localPosition = new Vector2(-2000, 0);
            currentPanelStr = "Panel2";
        }
        else if (currentPanelStr == "Panel2")
        {
            this.transform.localPosition = new Vector2(-1000, 0);
            currentPanelStr = "Panel1";
        }
        else
        {
            this.transform.localPosition = new Vector2(0, 0);
            currentPanelStr = "Panel0";
        }
    }

}