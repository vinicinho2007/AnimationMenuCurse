using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using NaughtyAttributes;
using DG.Tweening;

public class MenuSceneBase : MonoBehaviour
{
    public List<Transform> listObjs;
    public List<TextMeshProUGUI> listText;
    public float delayObjs, animDuration, delayText;

    [Button]
    public void Show()
    {
        StartCoroutine(ShowObjsCoroutine());
        StartCoroutine(ShowTextCoroutine());
    }

    [Button]
    public void Hide()
    {
        listObjs.ForEach(i => i.gameObject.SetActive(false));
        listText.ForEach(i => i.enabled = false);
    }

    IEnumerator ShowObjsCoroutine()
    {
        foreach(Transform t in listObjs)
        {
            t.gameObject.SetActive(true);
            t.DOScale(0, animDuration).From();
            yield return new WaitForSeconds(delayObjs);
        }
    }

    IEnumerator ShowTextCoroutine()
    {
        foreach(TextMeshProUGUI text in listText)
        {
            text.enabled = true;
            string s = text.text;
            text.text = "";
            foreach(char c in s.ToCharArray())
            {
                text.text += c;
                yield return new WaitForSeconds(delayText);
            }
        }
    }
}