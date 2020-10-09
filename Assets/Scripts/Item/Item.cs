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

    public void OnThis()
    {
        //ItemBoxに格納する
        ItemBox.instance.SetItem(type);
        Debug.Log(type+"を取得");
        //消える
        gameObject.SetActive(false);
    }
}
