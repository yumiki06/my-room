using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//矢印をクリックしたら、特定のPanelを表示する
public class PanelChanger : MonoBehaviour
{
    //矢印の表示・非表示
    public GameObject rightArrow;
    public GameObject leftArrow;
    public GameObject backArrow;

    //矢印の初期値（左右）
    private void Start()
    {
        rightArrow.SetActive(true);
        leftArrow.SetActive(true);
        backArrow.SetActive(false);
    }

    //詳細画面では戻る矢印のみを表示する
    void BackArrow()
    {
        rightArrow.SetActive(false);
        leftArrow.SetActive(false);
        backArrow.SetActive(true);
    }

    //使うパネルを列挙型で定義
    enum Panel
    {
        Panel0, Panel1, Panel2, Panel3,
        ToolboxPanel,
        TrashBoxPanel,
    }
    Panel currentPanel = Panel.Panel0;

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
