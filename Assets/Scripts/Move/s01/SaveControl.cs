using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Scripts.Move.s01
{
    public class SaveControl : MonoBehaviour
    {
        //    float _x, _z;
        //    public GameObject Player;
        //    public Button P;
        //    public int saveWhere;
        //    public GameObject WhatYouWantUI;
        //    public Button want;
        //    void Start()
        //    {
        //        //Button p = P[0].GetComponent<Button>();
        //        //p.onClick.AddListener(MouseDownOne);

        //        // 紀錄現在位置
        //        _x = Player.transform.position.x;
        //        _z = Player.transform.position.z;

        //        // 紫色存檔的按鈕
        //        Button p = P.GetComponent<Button>();
        //        p.onClick.AddListener(WhatYouWant);
        //    }

        //    void Update()
        //    {

        //    }

        //    public void WhatYouWant()
        //    {
        //        // 顯示詢問UI(三種選項)
        //        WhatYouWantUI.SetActive(true);
        //        Button w = want.GetComponent<Button>();
        //        if (gameObject.name == "SaveButton")
        //            w.onClick.AddListener(Save);
        //        if (gameObject.name == "BackButton")
        //            w.onClick.AddListener(Back);
        //        if (gameObject.name == "DoNotThingButton")
        //            w.onClick.AddListener(DoNotThing);
        //    }

        //    // 存檔
        //    public void Save()
        //    {
        //        Information.x[saveWhere] = _x;
        //        Information.z[saveWhere] = _z;
        //        WhatYouWantUI.SetActive(false);
        //    }

        //    // 回到過去位置
        //    public void Back()
        //    {
        //        Player.transform.position = new Vector2(Information.x[saveWhere], Information.z[saveWhere]);
        //        WhatYouWantUI.SetActive(false);
        //    }

        //    // 不做事
        //    public void DoNotThing()
        //    {
        //        //PlayerControl.SaveTime++;
        //        WhatYouWantUI.SetActive(false);
        //    }
    }
}
