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

    //使うパネルを列挙型で管理
    enum Panel
    {
        Panel0, Panel1, Panel2, Panel3,
        CandlePanel,
        ToolboxPanel, ToolboxOpenPanel, ArtPanel,
        TrashBoxPanel, NotePanel, DrawerPassPanel, DrawerOpenPanel0, DrawerOpenPanel1, DrawerOpenPanel2,
    }
    Panel currentPanel = Panel.Panel0;

    //表示するパネルを関数で定義し、引数を渡す
    void ShowPanel(Panel nextPanel)
    {
        currentPanel = nextPanel;
        if (nextPanel == Panel.Panel0)
        {
            this.transform.localPosition = new Vector2(0, 0);
        }
        else if (nextPanel == Panel.Panel1)
        {
            this.transform.localPosition = new Vector2(-1000, 0);
        }
        else if (nextPanel == Panel.Panel2)
        {
            this.transform.localPosition = new Vector2(-2000, 0);
        }
        else
        {
            this.transform.localPosition = new Vector2(-3000, 0);
        }
    }

    public void OnRightArrow()
    {
        if (currentPanel == Panel.Panel0)
        {
            ShowPanel(Panel.Panel1);
        }
        else if (currentPanel == Panel.Panel1)
        {
            ShowPanel(Panel.Panel2);
        }
        else if (currentPanel == Panel.Panel2)
        {
            ShowPanel(Panel.Panel3);
        }
        else
        {
            ShowPanel(Panel.Panel0);
        }
    }

    public void OnLeftArrow()
    {
        if (currentPanel == Panel.Panel0)
        {
            ShowPanel(Panel.Panel3);
        }
        else if (currentPanel == Panel.Panel1)
        {
            ShowPanel(Panel.Panel0);
        }
        else if (currentPanel == Panel.Panel2)
        {
            ShowPanel(Panel.Panel1);
        }
        else
        {
            ShowPanel(Panel.Panel2);
        }
    }

    public void OnBackArrow()
    {
        Start();
        //詳細画面の直前にいたPanelを表示する
        if (currentPanel == Panel.CandlePanel)
        {
            ShowPanel(Panel.Panel0);
        }
        else if (currentPanel == Panel.ArtPanel)
        {
            ShowPanel(Panel.Panel2);
        }
        else if (currentPanel == Panel.ToolboxPanel)
        {
            ShowPanel(Panel.Panel2);
        }
        else if (currentPanel == Panel.TrashBoxPanel)
        {
            ShowPanel(Panel.Panel3);
        }
        else if (currentPanel == Panel.NotePanel)
        {
            ShowPanel(Panel.Panel3);
        }
        else if (currentPanel == Panel.DrawerPassPanel)
        {
            ShowPanel(Panel.Panel3);
        }
        else if (currentPanel == Panel.DrawerOpenPanel0)
        {
            ShowPanel(Panel.Panel3);
        }
    }

    public void OnCandle()
    {
        this.transform.localPosition = new Vector2(0, 1500);
        currentPanel = Panel.CandlePanel;
        BackArrow();
    }
    public void OnToolbox()
    {
        this.transform.localPosition = new Vector2(-2000, 1500);
        currentPanel = Panel.ToolboxPanel;
        BackArrow();
    }
    public void OnToolboxOpen()
    {
        this.transform.localPosition = new Vector2(-2000, 3000);
        currentPanel = Panel.ToolboxPanel;
        BackArrow();
    }

    public void OnArt()
    {
        this.transform.localPosition = new Vector2(-2000, 4500);
        currentPanel = Panel.ArtPanel;
        BackArrow();
    }

    public void OnTrashBox()
    {
        this.transform.localPosition = new Vector2(-3000, 1500);
        currentPanel = Panel.TrashBoxPanel;
        BackArrow();
    }
    public void OnNote()
    {
        this.transform.localPosition = new Vector2(-3000, 3000);
        currentPanel = Panel.NotePanel;
        BackArrow();
    }
    public void OnDrawerPass()
    {
        this.transform.localPosition = new Vector2(-3000, 4500);
        currentPanel = Panel.DrawerPassPanel;
        BackArrow();
    }
    public void OnDrawerOpen0()
    {
        this.transform.localPosition = new Vector2(-3000, 6000);
        currentPanel = Panel.DrawerOpenPanel0;
        BackArrow();
    }
    public void OnDrawerOpen1()
    {
        this.transform.localPosition = new Vector2(-3000, 7500);
        currentPanel = Panel.DrawerOpenPanel0;
        BackArrow();
    }
    public void OnDrawerOpen2()
    {
        this.transform.localPosition = new Vector2(-3000, 9000);
        currentPanel = Panel.DrawerOpenPanel0;
        BackArrow();
    }
}