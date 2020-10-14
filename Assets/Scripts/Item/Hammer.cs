using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Hammer : Item
{
    public GameObject vaseBroken;
    public UnityEvent usedAction;

    public override void UseItem(bool active)
    {
        {
            // VaseBrokenが表示される
            vaseBroken.SetActive(true);
            // 音が鳴る
            usedAction.Invoke();
            base.UseItem(active);
        }
    }
}