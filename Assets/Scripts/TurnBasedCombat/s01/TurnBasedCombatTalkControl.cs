using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.TextCore.Text;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TurnBasedCombatTalkControl : MonoBehaviour
{
    ////public Text textTalk;
    ////public Button buttonRun;
    ////public string[] talkStart;
    ////public string[] talk01;
    ////public string[] talkRun;
    ////public GameObject gameObjectTalk;
    ////int Click01, Click02;
    //public string Scene;
    //public Text textRound;

    //void Start()
    //{
    //    //StartCoroutine(IEStart());
    //    //Button btn_run = buttonRun.GetComponent<Button>();
    //    //Button btn_01 = buttonTalk[1].GetComponent<Button>();
    //    //btn_run.onClick.AddListener(MouseDownOneTalkRun);
    //}

    ////IEnumerator IEStart()
    ////{
    ////    gameObjectTalk.SetActive(true);
    ////    textTalk.text = talkStart[0];

    ////    yield return new WaitForSeconds(1f);

    ////    textTalk.text = "";
    ////}

    //public void MouseDownOneTalkRun()
    //{
    //    //Click01++;
    //    //int e;
    //    //e = Click01 % (talkRun.Length + 1);
    //    StartCoroutine(LoadSceneMove());

    //    IEnumerator LoadSceneMove()
    //    {
    //        //gameObjectTalk.SetActive(true);
    //        //for (int i = 0; i < talkRun.Length; i++)
    //        //{
    //            //textTalk.text = talkRun[i];
    //            yield return new WaitForSeconds(1.5f);
    //        //}

    //        SceneManager.LoadScene(Scene);
    //    }
    //}

    //void Update()
    //{
    //    textRound.text = "²Ä" + OverallControl.intRound + "¦^¦X";
    //}

    ////public void MouseDownOne()
    ////{
    ////    Button btn_talk = buttonTalk[0].GetComponent<Button>();
    ////    btn_talk.onClick.AddListener();
    ////}

    ////public void MouseDownOneTalk00()
    ////{
    ////    Click01++;
    ////    int e;
    ////    e = Click01 % (talkStart.Length + 1);
    ////    if (e == 0)
    ////    {
    ////        gameObjectTalk.SetActive(false);
    ////        Click02 = 0;
    ////        Click01 = 0;
    ////    }
    ////    else
    ////    {
    ////        gameObjectTalk.SetActive(true);
    ////        textTalk.text = talkStart[Click02];
    ////        Click02++;
    ////    }
    ////}
}
