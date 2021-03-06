﻿using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class DrawerPass : MonoBehaviour
{
    private string chars = "ACEGHIOPTU";
    public Text[] texts;
    private int[] nums = {0,0,0,0,0,0,0,0,0,0};

    public void ChangeText(int n)
    {
        // n番目のボタンのテキストが1つずつ先に進む
        nums[n] += 1;
        // 9番目まで行ったら0番目に戻る）
        if(nums[n] >= chars.Length)
        {
            nums[n] = 0;
        }
        texts[n].text = chars[nums[n]].ToString();
        CheckPassword();
    }

    public UnityEvent soundAction;
    public void CheckPassword() 
    {
        string correctPassword = "TEA";
        string inputPassword = "";
        foreach(Text text in texts)
        {
            inputPassword += text.text;
        }
        if (correctPassword == inputPassword)
        {
            soundAction.Invoke();
            OpenAction.Invoke();
        }
    }
    // 外部から取得した関数を実行する
    public UnityEvent OpenAction;
}
