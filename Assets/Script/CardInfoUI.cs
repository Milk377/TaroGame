using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CardInfoUI : MonoBehaviour
{
    static public CardInfoUI instance;
    Animation animation;
    public Text text2;
    public Text text4;
    public Image torotImage;

    public void SetInstance()
    {
        instance = this;
    }

    private void Awake()
    {
        animation = GetComponent<Animation>();
    }

    public void Init()
    {
        gameObject.SetActive(true);

        StartCoroutine(InitCo());
    }

    IEnumerator InitCo()
    {
        // 카드 정보 연결하기(카드 이름, 이미지..)
        string cardName = UIManager.selectCardInfo.Name;             // Table에서 가져옴
        string spriteName = UIManager.selectCardInfo.Sprite;      // Table에서 가져옴
        Sprite sprite = Resources.Load<Sprite>("TarotCard/" + spriteName);
        text2.text = string.Format("상대방의 생각에 대해서 알고 싶은 지금 \"{0}\"카드를 선택하셨습니다.", cardName);
        text4.text = UIManager.selectCardInfo.Explaine;

        torotImage.sprite = sprite;
        animation.Play("In");

        yield return new WaitForSeconds(0.5f);

        ConfirmCardUI.instance.Close();
    }

    public void OnClickClose()
    {
        gameObject.SetActive(false);
    }
}
