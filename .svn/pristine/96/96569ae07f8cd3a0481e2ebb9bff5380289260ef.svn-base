using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadingUI : MonoBehaviour
{
    static public LoadingUI instance;

    public void SetInstance()
    {
        instance = this;
    }

    public void Init()
    {
        gameObject.SetActive(true);

        StartCoroutine(InitCo());
    }

    private IEnumerator InitCo()
    {
        // N초 대기
        yield return new WaitForSeconds(1f);

        // ComfirmCardUI를 켠다.
        ConfirmCardUI.instance.Init();

        SelectCardUI.instance.Close();

        gameObject.SetActive(false);
    }


}
