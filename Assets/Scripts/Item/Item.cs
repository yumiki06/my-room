using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//アイテムをクリックすると、ItemBoxに格納され、最初の場所から消える
public class Item : MonoBehaviour
{
    //アイテムを列挙型で管理
    public enum Type
    {
        Wallpaper, Cat, //Panel0
        Hammer, Rubber, //Panel1
        Vase, VaseBroken, SilverKey, GoldKey, ToolboxButton, Art, //Panel2
        //Panel3（無し）

        //Panel0（無し）
        CatFood, Screwdriver, //Panel1
        RightEye, //Pane2
        LeftEye, Dirt, Match, Paper, //Panel3
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
