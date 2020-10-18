using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class SilverKey : Item
{
    public UnityEvent OpenAction;
    public GameObject dissapearAction;
    public override void UseItem(bool active)
    {
        if(selected.activeSelf)
        {
            OpenAction.Invoke();
            base.UseItem(active);
            dissapearAction.SetActive(false);
        }
    }
}