using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class SwipeController : MonoBehaviour, IEndDragHandler
{
    [SerializeField] int maxPage;
    int currentPage;
    Vector3 tagetPos;
    [SerializeField] Vector3 pageStep;
    [SerializeField] RectTransform levelPagesRect;

    [SerializeField] float tweenTime;
    [SerializeField] LeanTweenType tweenType;
    float dragThreshould;

    private void Awake()
    {
        currentPage = 1;
        tagetPos = levelPagesRect.localPosition;
        dragThreshould = Screen.width / 15;
    }

    public void Next()
    {
        if (currentPage < maxPage)
        {
            currentPage++;
            tagetPos += pageStep;
            MovePage();
        }
    }

    public void Previous()
    { 
        if (currentPage > 1)
        {
            currentPage--;
            tagetPos -= pageStep;
            MovePage();
        }
    }

    void MovePage()
    {
        levelPagesRect.LeanMoveLocal(tagetPos, tweenTime).setEase(tweenType);
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        if (Mathf.Abs(eventData.position.x - eventData.pressPosition.x) > dragThreshould)
        {
            if (eventData.position.x > eventData.pressPosition.x) Previous();
            else Next();
        }
        else
        {
            MovePage();
        }
    }

    public void Man1()
    {
        SceneManager.LoadScene("Man1");
    }
    public void Man2()
    {
        SceneManager.LoadScene("Man2");
    }
    public void Man3()
    {
        SceneManager.LoadScene("Man3");
    }
    public void Man4()
    {
        SceneManager.LoadScene("Man4");
    }
    public void Man5()
    {
        SceneManager.LoadScene("Man5");
    }
    public void Man6()
    {
        SceneManager.LoadScene("Man6");
    }
    public void Man7()
    {
        SceneManager.LoadScene("Man7");
    }
}
