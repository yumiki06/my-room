using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hammer : Item
{
    public GameObject action;
    public override void UseItem(bool active)
    {
        if(selected.activeSelf)
        {
            // VaseBrokenが表示される
            action.SetActive(true);
            base.UseItem(active);
        }
    }
}