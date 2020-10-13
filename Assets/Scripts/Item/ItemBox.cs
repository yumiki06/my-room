using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemBox : MonoBehaviour
{
    // 配列で管理する
    public GameObject[] boxes;

    // static化して、どのファイルからでも参照できるようにする
    public static ItemBox instance;
    private void Awake()
    {
        instance = this;
    }

    // BoxにItemを格納する（Item画像を表示する）
    // 特定のアイテムを持っているか判断する
    // Itemを使用したら非表示にする

    public void SetItem(Item.Type type)
    {
        int index = (int)type;
        boxes[index].SetActive(true);

        /* 配列を使用することで、アイテムの数だけ条件分岐させる必要がなくなる
        if (type == Item.Type.Hammer)
        {
            box0.SetActive(true);
            boxes[0].SetActive(true);
        }
        */
    }

    public bool CanUseItem(Item.Type type)
    {
        // アイテムを所持していたら（ItemBoxに表示されていたら）使用できる
        // 表示されているかどうかをactiveSelfで判断
        int index = (int)type;
        return boxes[index].activeSelf;

        /* 配列を使用することで、アイテムの数だけ条件分岐させる必要がなくなる
        if (type == Item.Type.Hammer)
        {
            return box0.activeSelf;
        }
        return false;
        */
    }

    public void UseItem(Item.Type type)
    {
        int index = (int)type;
        boxes[index].SetActive(false);
    }
}
