using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// 数字をクリックすると1ずつ数字が増える
public class ToolboxPass : MonoBehaviour
{
    public Text[] texts;
    public void ChangeText(int n)
    {
        // n番目のボタンの中のテキストが1ずつ増える
        int i = int.Parse(texts[n].text) +1;
        // 10以上の場合は0を代入する（9まで行ったら0に戻る）
        if(i >= 10)
        {
            i = 0;
        }
        texts[n].text = i.ToString();
    }
