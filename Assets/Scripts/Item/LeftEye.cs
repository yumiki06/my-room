using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class LeftEye : Item
{
    public GameObject leftEye;
    public UnityEvent usedAction;

    public override void UseItem(bool active)
    {
        {
            // leftEyeが表示される
            leftEye.SetActive(true);
            // 音が鳴る
            usedAction.Invoke();
            base.UseItem(active);
        }
    }
}
