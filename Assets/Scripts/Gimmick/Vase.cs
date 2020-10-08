using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//クリック時にHummerを持っていたら、Vaseが消えて、VaseBrokeが表示される
public class Vase : MonoBehaviour
{    
    public GameObject vaseBroken;

    public void OnThis()
    {
        //ItemBoxにHummerがあるか探し、持っていたら
        bool hasItem = ItemBox.instance.CanUseItem(Item.Type.Hammer);
        if (hasItem == true)
        {
            //Vaseが消えて
            gameObject.SetActive(false);
            //VaseBrokenが表示される
            vaseBroken.SetActive(true);
            //アイテムを使う
            ItemBox.instance.UseItem(Item.Type.Hammer);
        }
    }
}