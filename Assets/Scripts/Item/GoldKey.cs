using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GoldKey : Item
{
    public GameObject action;
    public override void UseItem(bool active)
    {
        if(selected.activeSelf)
        {
            action.SetActive(true);
            base.UseItem(active);
        }
    }
}