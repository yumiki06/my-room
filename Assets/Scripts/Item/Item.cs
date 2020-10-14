using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//アイテムをクリックすると、ItemBoxに格納され、最初の場所から消える
public class Item : MonoBehaviour
{
    //アイテムを列挙型で管理
    public enum Type
    {
        Hammer, Rubber, CatFood, Screwdriver, //Panel1
        SilverKey, GoldKey, RightEye, //Panel2
        LeftEye, Match, Paper, //Panel3
    }

    public Type type;

    public GameObject itemOnPanel;
    public GameObject itemOnBox;
    public GameObject selected;

    public void GetItem()
    {
        itemOnPanel.SetActive(false);
        itemOnBox.SetActive(true);
    }

    public void SelectItem()
    {
        if(selected.activeSelf)
        {
            selected.SetActive(true);
        }
        else if(itemOnBox.activeSelf)
        {
            GameObject[] selects = GameObject.FindGameObjectsWithTag("Selected");
            foreach(GameObject select in selects)
            {
                select.SetActive(false);
            }
            selected.SetActive(true);
        }
    }
}