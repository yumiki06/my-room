using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatFood : Item
{
    public GameObject dishAction;
    public GameObject dissapearAction;
    public GameObject dissapearAction1;
    public GameObject appearAction;
    public override void UseItem(bool active)
    {
        if(selected.activeSelf)
        {
            dishAction.SetActive(true);
            dissapearAction.SetActive(false);
            dissapearAction1.SetActive(false);
            appearAction.SetActive(true);
            base.UseItem(active);
        }
    }
}