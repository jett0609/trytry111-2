using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StoreControl : MonoBehaviour
{
    bool PlayerBool = false;
    public Text TextStore;
    public string[] stringStore;
    int e1;
    public int talkTime;
    public GameObject storeUI;
    void Start()
    {
        
    }

    void Update()
    {
        // 如果按了E
        if (Input.GetKeyDown(KeyCode.E))
        {
            // 開商店
            Store();
        }
        // 如果按了Escape
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            // 關商店
            storeUI.SetActive(false);
            StopCoroutine(StoreTalk());
        }
    }

    void Store()
    {
        // 如果在商店範圍
        if (PlayerBool == true)
        {
            storeUI.SetActive(true);
            StartCoroutine(StoreTalk());
            //int _e = e1 % (stringStore.Length + 1);
            //if (_e == 0)
            //{
            //    storeUI.SetActive(false);
            //    e2 = 0;
            //}
            //else
            //{
            //    storeUI.SetActive(true);
            //    TalkStore();
            //    e2++;
            //}

            //switch (_e)
            //{
            //    // 關商店
            //    case 0:
            //        storeUI.SetActive(false);
            //        break;
            //    // 開商店
            //    case 1:
            //        storeUI.SetActive(true);
            //        TalkStore();
            //        e2 += 1;
            //        break;
            //}
        }
    }

    IEnumerator StoreTalk()
    {
        while (true)
        {
            e1 = Random.Range(0, stringStore.Length);
            TextStore.text = stringStore[e1];

            yield return new WaitForSeconds(talkTime);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            PlayerBool = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            PlayerBool = false;
        }
    }

    //void TalkStore()
    //{
    //    TextStore.text = stringStore[e2];
    //}

}
