using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TaroCard : MonoBehaviour
{
    private Animation animation;
    private Image frontImage;

    private void Awake()
    {
        animation = GetComponent<Animation>();
        frontImage = transform.Find("Front").GetComponent<Image>();
    }

    public void DelayRotation(float delayTime)
    {
        StartCoroutine(DelayRotationCo(delayTime));
    }

    public IEnumerator DelayRotationCo(float delayTime)
    {
        yield return new WaitForSeconds(delayTime);

        // 회전
        animation.Play("Start");
    }

    public void OnClick()
    {
        print("OnClick");
        StartCoroutine(OnClickCo());
    }

    private IEnumerator OnClickCo()
    {
        // Front이미지 변경
        //int selectCardNumber = Random.Range(0, 22);
        int selectCardNumber = Random.Range(0, 2);
        var cardInfo = CardTable.GetAt(selectCardNumber);

        UIManager.selectCardInfo = cardInfo;
        Sprite sprite = Resources.Load<Sprite>("TarotCard/" + selectCardNumber);
        frontImage.sprite = sprite;


        // 선택 애니메이션 실행
        animation.Play("Pick");

        yield return new WaitForSeconds(1);

        LoadingUI.instance.Init();
    }


}
