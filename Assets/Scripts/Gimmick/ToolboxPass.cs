using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// 数字をクリックすると1ずつ数字が増える
// 4桁の数字が正解なら、箱が開く
public class ToolboxPass : MonoBehaviour
{
    public Text[] texts;
    
    public void ChangeText(int n)
    {
        // n番目のボタンの数字が1ずつ増える
        int i = int.Parse(texts[n].text) +1;
        // 10以上の場合は0を代入する（9まで行ったら0に戻る）
        if(i >= 10)
        {
            i = 0;
        }
        texts[n].text = i.ToString();
        CheckPassword();
    }

    public void CheckPassword() 
    {
        string correctPassword = "3250";
        string inputPassword = "";
        foreach(Text text in texts)
        {
            inputPassword += text.text;
        }
