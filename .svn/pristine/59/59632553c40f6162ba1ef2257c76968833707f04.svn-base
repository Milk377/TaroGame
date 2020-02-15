using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelectCardUI : MonoBehaviour
{
    static public SelectCardUI instance;
    private Animation animation;

    public TaroCard taroCard;
    private Transform cardGroup;
    private Text explaineText;
    private List<TaroCard> taroCardList = new List<TaroCard>();
    private int menuType;

    public void SetInstance()
    {
        instance = this;
    }

    private void Awake()
    {
        animation = GetComponent<Animation>();
        cardGroup = transform.Find("CardGroup");
        explaineText = transform.Find("ExplaineText").GetComponent<Text>();
    }

    public void Init(int menuType)
    {
        print("Init: " + menuType);
        this.menuType = menuType;
        gameObject.SetActive(true);
        StartCoroutine(InitCo());
    }

    private IEnumerator InitCo()
    {
        // 카드 생성
        MakeCardGroup();

        // 설명입력
        var menuInfo = MenuTable.GetAt(menuType);
        explaineText.text = menuInfo.Explaine;

        animation.Play("In");
        yield return new WaitForSeconds(0.5f);

        // 모든 카드 랜덤한 시간에 애니메이션
        AllCardRotation();
    }

    // 모든 카드 랜덤한 시간에 애니메이션
    private void AllCardRotation()
    {
        foreach (TaroCard taroCard in taroCardList)
        {
            taroCard.DelayRotation(Random.Range(0, 0.5f));
        }
    }

    private void MakeCardGroup()
    {
        int cardCount = 22;
        for (int i = 0; i < cardCount; i++)
        {
            TaroCard newTaroCard = Instantiate(taroCard);
            newTaroCard.transform.SetParent(cardGroup);
            taroCardList.Add(newTaroCard);
        }
    }

    private void DestroyAllCard()
    {
        foreach(var iter in taroCardList)
        {
            Destroy(iter.gameObject);
        }
        taroCardList.Clear();
    }

    public void OnClickBack()
    {
        print("OnClickBack");
        
        if (HideCo_ != null)
            StopCoroutine(HideCo_);
        HideCo_ = StartCoroutine(HideCo());
        StartCoroutine(HideCo());
    }

    private Coroutine HideCo_;
    private IEnumerator HideCo()
    {
        animation.Play("Out");
        yield return new WaitForSeconds(0.5f);
        DestroyAllCard();
        gameObject.SetActive(false);
    }

    public void Close()
    {
        gameObject.SetActive(false);
    }
}
