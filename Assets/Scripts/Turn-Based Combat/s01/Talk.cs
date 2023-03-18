using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.TextCore.Text;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Talk : MonoBehaviour
{
    public Text textTalk;
    public Button[] buttonTalk;
    public string[] talkStart;
    public string[] talk01;
    public string[] talk02;
    public string[] talk03;
    public string[] talkRun;
    public GameObject gameObjectTalk;
    int Click01, Click02;
    public string Scene;
    void Start()
    {
        textTalk.text = talkStart[0];
        Button btn_talk = buttonTalk[0].GetComponent<Button>();
        Button btn_01 = buttonTalk[1].GetComponent<Button>();
        Button btn_02 = buttonTalk[2].GetComponent<Button>();
        Button btn_03 = buttonTalk[3].GetComponent<Button>();
        Button btn_04 = buttonTalk[4].GetComponent<Button>();
        btn_talk.onClick.AddListener(MouseDownOneTalk00);
        btn_01.onClick.AddListener(MouseDownOneTalk01);
        btn_02.onClick.AddListener(MouseDownOneTalk02);
        btn_03.onClick.AddListener(MouseDownOneTalk03);
        btn_04.onClick.AddListener(MouseDownOneTalkRun);
    }

    
    void Update()
    {
        
    }

    //public void MouseDownOne()
    //{
    //    Button btn_talk = buttonTalk[0].GetComponent<Button>();
    //    btn_talk.onClick.AddListener();
    //}

    public void MouseDownOneTalk00()
    {
        Click01++;
        int e;
        e = Click01 % (talkStart.Length + 1);
        if (e == 0)
        {
            gameObjectTalk.SetActive(false);
            Click02 = 0;
            Click01 = 0;
        }
        else
        {
            gameObjectTalk.SetActive(true);
            textTalk.text = talkStart[Click02];
            Click02++;
        }
    }

    public void MouseDownOneTalk01()
    {
        Click01++;
        int e;
        e = Click01 % (talk01.Length + 1);
        if (e == 0)
        {
            gameObjectTalk.SetActive(false);
            Click02 = 0;
            Click01 = 0;
        }
        else
        {
            gameObjectTalk.SetActive(true);
            textTalk.text = talk01[Click02];
            Click02++;
        }
    }

    public void MouseDownOneTalk02()
    {
        Click01++;
        int e;
        e = Click01 % (talk02.Length + 1);
        if (e == 0)
        {
            gameObjectTalk.SetActive(false);
            Click02 = 0;
            Click01 = 0;
        }
        else
        {
            gameObjectTalk.SetActive(true);
            textTalk.text = talk02[Click02];
            Click02++;
        }
    }

    public void MouseDownOneTalk03()
    {
        Click01++;
        int e;
        e = Click01 % (talk03.Length + 1);
        if (e == 0)
        {
            gameObjectTalk.SetActive(false);
            Click02 = 0;
            Click01 = 0;
        }
        else
        {
            gameObjectTalk.SetActive(true);
            textTalk.text = talk03[Click02];
            Click02++;
        }
    }

    public void MouseDownOneTalkRun()
    {
        Click01++;
        int e;
        e = Click01 % (talkRun.Length + 1);
        StartCoroutine(LoadSceneMove());

        IEnumerator LoadSceneMove()
        {
            gameObjectTalk.SetActive(true);
            textTalk.text = talkRun[Click02];
            Click02++;

            yield return new WaitForSeconds(1);

            SceneManager.LoadScene(Scene);
        }
    }
}
