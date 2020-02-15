using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ConfirmCardUI : MonoBehaviour
{
    static public ConfirmCardUI instance;

    Image resultImage;

    public void SetInstance()
    {
        instance = this;
    }

    
    private void Awake()
    {
        resultImage = transform.Find("ResultImage").GetComponent<Image>();
    }
    public void Init()
    {
        gameObject.SetActive(true);
        Sprite sprite = Resources.Load<Sprite>("TarotCard/" + UIManager.selectCardInfo.Sprite);
        resultImage.sprite = sprite;
    }

    public void OnClickShowResult()
    {
        CardInfoUI.instance.Init();
    }

    public void Close()
    {
        gameObject.SetActive(false);
    }
}
