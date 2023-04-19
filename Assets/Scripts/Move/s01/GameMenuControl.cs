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
        // �a�Ϧ�m


        // �p�ɾ�
        if (PlayerControl.UI!=true)
        {
            floatTime += Time.deltaTime;
        }
        float allGameTimeSec = Mathf.Floor(floatTime);
        float GameTimeHour = Mathf.Floor(allGameTimeSec / 60 / 60);
        float GameTimeMinute = Mathf.Floor(allGameTimeSec / 60);
        float GameTimeSecond = allGameTimeSec % 60;

        // �C���i��
        TextSchedule.text = "�C���i�� : \nChapter " + intChapter + "\n\n�Ҧb�a�� : " + stringMap + "\n\n�C���ɶ� : " + GameTimeHour + "h\t" + GameTimeMinute + "m\t" + GameTimeSecond + "s";

        // ��ܸ�T(��)
        TextMoney.text = "�ҫ����� : " + intMoney;


        // �s�XGameMenu
        GameMenu();
    }

    void GameMenu()
    {
        // 
        if (Input.GetKeyDown(KeyCode.Escape) && PlayerControl.boolStoreUI == false)
        {
            // �O��������
            GameMenuTime++;

            if (GameMenuTime % 2 == 1)
            {
                GameMenuUI.SetActive(true);
                PlayerControl.UI = true;
            }
            else
            {
                Back();

                GameMenuUI.SetActive(false);
                PlayerControl.UI = false;
            }
        }
    }

    public void Item()
    {
        Back();
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
        Back();
        gameObjectEquip.gameObject.SetActive(true);
    }

    public void StateOfCharacter()
    {
        Back();
        gameObjectStateOfCharacter.gameObject.SetActive(true);
    }

    public void Tip()
    {
        Back();
        gameObjectTip.gameObject.SetActive(true);
    }

    public void Save()
    {
        Back();
        gameObjectSave.SetActive(true);
    }

    public void SetUp()
    {
        Back();
        gameObjectSetUp.SetActive(true);
    }

    public void Back()
    {
        gameObjectItem.gameObject.SetActive(false);
        gameObjectSkill.gameObject.SetActive(false);
        gameObjectEquip.gameObject.SetActive(false);
        gameObjectStateOfCharacter.gameObject.SetActive(false);
        gameObjectTip.gameObject.SetActive(false);
        gameObjectSave.SetActive(false);
        gameObjectSetUp.SetActive(false);
    }
}
