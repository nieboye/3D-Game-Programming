using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Button_Behaviour : MonoBehaviour {

    private Button button;
    public Text text;
    //公告内容的变化帧数
    private int frame = 20;
    //公告文本的高度
    private float height;

    // Use this for initialization  
    void Start()
    {
        //获取button，添加监听事件
        button = this.gameObject.GetComponent<Button>();
        button.onClick.AddListener(TaskOnClick);

        height = text.rectTransform.sizeDelta.y;
    }

    IEnumerator rotateIn()
    {
        float hei = height;

        for(int i = 0;i < frame; i++)
        {
            hei -= height / frame;
            text.rectTransform.sizeDelta = new Vector2(text.rectTransform.sizeDelta.x, hei);
            // 在这停顿，下一帧再执行
            yield return null;
        }
        // 禁用文本
        text.gameObject.SetActive(false);
    }

    IEnumerator rotateOut()
    {
        float hei = 0;
        // 激活文本
        text.gameObject.SetActive(true);

        for (int i = 0; i < frame; i++)
        {
            hei += height / frame;
            text.rectTransform.sizeDelta = new Vector2(text.rectTransform.sizeDelta.x, hei);
            // 在这停顿，下一帧再执行
            yield return null;
        }
    }

    void TaskOnClick()
    {
        if (text.gameObject.activeSelf)
        {
            StartCoroutine(rotateIn());
        }
        else
        {
            StartCoroutine(rotateOut());
        }
    }
}