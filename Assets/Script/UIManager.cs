﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    static public CardTable.Row selectCardInfo;


    private void Awake()
    {
        transform.Find("SelectCardUI").GetComponent<SelectCardUI>().SetInstance();
        transform.Find("SelectCardUI").gameObject.SetActive(false);

        transform.Find("ConfirmCardUI").GetComponent<ConfirmCardUI>().SetInstance();
        transform.Find("ConfirmCardUI").gameObject.SetActive(false);

        transform.Find("LoadingUI").GetComponent<LoadingUI>().SetInstance();
        transform.Find("LoadingUI").gameObject.SetActive(false);

        transform.Find("CardInfoUI").GetComponent<CardInfoUI>().SetInstance();
        transform.Find("CardInfoUI").gameObject.SetActive(false);
    }
}
