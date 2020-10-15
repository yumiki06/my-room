using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftEye : Item
{
    public GameObject action;
    public override void UseItem(bool active)
    {
        if(selected.activeSelf)
        {
            // 画像が表示される
            action.SetActive(true);
            base.UseItem(active);
        }
    }
}
