using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuCard : MonoBehaviour
{
    public int cardType;

    public void OnClickSelect()
    {
        print(name + "OnClickSelect: " + cardType);
        SelectCardUI.instance.Init(cardType);
    }
}
