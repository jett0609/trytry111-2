using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameMenuControl : MonoBehaviour
{
    public GameObject GameMenuUI;
    public Button Button01, Button02, Button03, Button04, Button05, Button06, Button07;
    public GameObject gameObjectItem, gameObjectSkill, gameObjectEquip, gameObjectStateOfCharacter, gameObjectTip, gameObjectSave, gameObjectSetUp;
    public Text TextSchedule, TextMoney;
    public static int intMoney;
    public static float floatTime;
    public static int intChapter;
    public static string stringMap;
    int GameMenuTime = 0;

    void Start()
    {
        DontDestroyOnLoad(this.gameObject);
        DontDestroyOnLoad(GameMenuUI.gameObject);
    }

    void Update()
    {
        // 地圖位置


        // 計時器
        if (PlayerControl.UI!=true)
        {
            floatTime += Time.deltaTime;
        }
        float allGameTimeSec = Mathf.Floor(floatTime);
        float GameTimeHour = Mathf.Floor(allGameTimeSec / 60 / 60);
        float GameTimeMinute = Mathf.Floor(allGameTimeSec / 60);
        float GameTimeSecond = allGameTimeSec % 60;

        // 遊戲進度
        TextSchedule.text = "遊戲進度 : \nChapter " + intChapter + "\n\n所在地區 : " + stringMap + "\n\n遊戲時間 : " + GameTimeHour + "h\t" + GameTimeMinute + "m\t" + GameTimeSecond + "s";

        // 顯示資訊(錢)
        TextMoney.text = "所持金錢 : " + intMoney;


        // 叫出GameMenu
        GameMenu();
    }

    void GameMenu()
    {
        // 
        if (Input.GetKeyDown(KeyCode.Escape) && PlayerControl.boolStoreUI == false)
        {
            // 記按的次數
            GameMenuTime++;

            if (GameMenuTime % 2 == 1)
            {
                GameMenuUI.SetActive(true);
                PlayerControl.UI = true;
            }
            else
            {
                gameObjectItem.gameObject.SetActive(false);
                gameObjectSkill.gameObject.SetActive(false);
                gameObjectEquip.gameObject.SetActive(false);
                gameObjectStateOfCharacter.gameObject.SetActive(false);
                gameObjectTip.gameObject.SetActive(false);
                gameObjectSave.SetActive(false);
                gameObjectSetUp.SetActive(false);

                GameMenuUI.SetActive(false);
                PlayerControl.UI = false;
            }
        }
    }

    public void Item()
    {
        gameObjectSkill.gameObject.SetActive(false);
        gameObjectEquip.gameObject.SetActive(false);
        gameObjectStateOfCharacter.gameObject.SetActive(false);
        gameObjectTip.gameObject.SetActive(false);
        gameObjectSave.SetActive(false);
        gameObjectSetUp.SetActive(false);
        gameObjectItem.gameObject.SetActive(true);
    }

    public void Skill()
    {
        gameObjectItem.gameObject.SetActive(false);
        gameObjectEquip.gameObject.SetActive(false);
        gameObjectStateOfCharacter.gameObject.SetActive(false);
        gameObjectTip.gameObject.SetActive(false);
        gameObjectSave.SetActive(false);
        gameObjectSetUp.SetActive(false);
        gameObjectSkill.gameObject.SetActive(true);
    }

    public void Equip()
    {
        gameObjectItem.gameObject.SetActive(false);
        gameObjectSkill.gameObject.SetActive(false);
        gameObjectStateOfCharacter.gameObject.SetActive(false);
        gameObjectTip.gameObject.SetActive(false);
        gameObjectSave.SetActive(false);
        gameObjectSetUp.SetActive(false);
        gameObjectEquip.gameObject.SetActive(true);
    }

    public void StateOfCharacter()
    {
        gameObjectItem.gameObject.SetActive(false);
        gameObjectSkill.gameObject.SetActive(false);
        gameObjectEquip.gameObject.SetActive(false);
        gameObjectTip.gameObject.SetActive(false);
        gameObjectSave.SetActive(false);
        gameObjectSetUp.SetActive(false);
        gameObjectStateOfCharacter.gameObject.SetActive(true);
    }

    public void Tip()
    {
        gameObjectItem.gameObject.SetActive(false);
        gameObjectSkill.gameObject.SetActive(false);
        gameObjectEquip.gameObject.SetActive(false);
        gameObjectStateOfCharacter.gameObject.SetActive(false);
        gameObjectSave.SetActive(false);
        gameObjectSetUp.SetActive(false);
        gameObjectTip.gameObject.SetActive(true);
    }

    public void Save()
    {
        gameObjectItem.gameObject.SetActive(false);
        gameObjectSkill.gameObject.SetActive(false);
        gameObjectEquip.gameObject.SetActive(false);
        gameObjectStateOfCharacter.gameObject.SetActive(false);
        gameObjectTip.gameObject.SetActive(false);
        gameObjectSetUp.SetActive(false);
        gameObjectSave.SetActive(true);
    }

    public void SetUp()
    {
        gameObjectItem.gameObject.SetActive(false);
        gameObjectSkill.gameObject.SetActive(false);
        gameObjectEquip.gameObject.SetActive(false);
        gameObjectStateOfCharacter.gameObject.SetActive(false);
        gameObjectTip.gameObject.SetActive(false);
        gameObjectSave.SetActive(false);
        gameObjectSetUp.SetActive(true);
    }
}
