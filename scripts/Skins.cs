using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Skins : MonoBehaviour
{
    private int id;
    public Sprite[] skins;
    public GameObject currentSkin;

    private void Start()
    {
        id = 0;
        currentSkin.GetComponent<Image>().sprite = skins[id];
    }


    public void NextSkin()
    {
        id++;
        if (id == skins.Length)
            id = 0;
        currentSkin.GetComponent<Image>().sprite = skins[id];
    }

    public void PrevSkin()
    {
        id--;
        if (id == -1)
            id = skins.Length - 1;
        currentSkin.GetComponent<Image>().sprite = skins[id];
    }
}
