﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

//アイテムをクリックすると、ItemBoxに格納され、最初の場所から消える
public class Item : MonoBehaviour
{
    public GameObject itemOnPanel;
    public GameObject itemOnBox;
    public GameObject selected;
    public GameObject target;
    public Image image;
    public UnityEvent soundAction;
    private bool used = false;

    public void GetItem()
    {
        itemOnPanel.SetActive(false);
        itemOnBox.SetActive(true);
    }

    public void SelectItem()
    {
        if(selected.activeSelf)
        {
            selected.SetActive(true);
        }
        else if(itemOnBox.activeSelf && !used)
        {
            GameObject[] selects = GameObject.FindGameObjectsWithTag("Selected");
            foreach(GameObject select in selects)
            {
                select.SetActive(false);
            }
            selected.SetActive(true);
        }
    }

    public virtual void UseItem(bool active)
    {
        if(selected.activeSelf)
        {
            target.SetActive(active);
            used = true;
            selected.SetActive(false);
            image.color = new Color(1.0f,1.0f,1.0f,0.4f);
            // 音が鳴る
            soundAction.Invoke();
        }
    }
}