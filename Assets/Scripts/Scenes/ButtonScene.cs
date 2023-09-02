using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using DG.Tweening;

public class ButtonScene : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public TypeScene type;
    public float durationAnim, scaleNew;
    private Vector3 _scaleStart;
    private Tween _currentTween;

    private void Awake()
    {
        _scaleStart = transform.localScale;
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        _currentTween=transform.DOScale(scaleNew, durationAnim);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        _currentTween.Kill();
        transform.DOScale(_scaleStart, durationAnim);
    }

    public void ToChangeScene()
    {
        _currentTween.Kill();
        transform.localScale = _scaleStart;
        GameObject.FindObjectOfType<SceneManager>().ToChangeScene(type);
    }
}