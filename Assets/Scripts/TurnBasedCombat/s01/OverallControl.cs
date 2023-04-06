using Newtonsoft.Json.Linq;
using Scripts.RoleInformation;
using Scripts.TurnBasedCombat.s01;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OverallControl : MonoBehaviour
{
    //public static bool _buttonUsing = false;
    //public static bool buttonUsing
    //{
    //    get
    //    {
    //        return _buttonUsing;
    //    }
    //    set
    //    {
    //        value = buttonUsing;
    //        _buttonUsing = value;
    //    }
    //}

    int b;
    int a;
    public static int[] Player = new int[3];
    //public static int[] PlayerHP;
    public static int[] PlayerSpeed;
    public static int[] Aite = new int[3];
    //public static int[] AiteHP;
    public static int[] AiteSpeed;
    public static int[] All;
    //public static int[] AllHP;
    public static int[] AllSpeed;
    public static int intRound = 1;
    //public string[] talk;



    void Start()
    {
        StartCoroutine(Overall());
        //OverallControlStart();

        //Player[0] = DominateInformation.name;
        //PlayerHP[0] = DominateInformation.MaxHP;
        //Aite[0] = WoodenDragonInformation.name;
        //AiteHP[0] = WoodenDragonInformation.MaxHP;
    }

    void Update()
    {
        
    }

    IEnumerator Overall()
    {
        yield return new WaitForSeconds(1);

        //輸入數值
        Player[0] = DominateInformation.NumberPlayer;
        PlayerSpeed[0] = DominateInformation.Speed;
        Aite[0] = WoodenDragonInformation.NumberAite;
        AiteSpeed[0] = WoodenDragonInformation.Speed;
        All[0] = Player[0];
        AllSpeed[0] = PlayerSpeed[0];
        All[1] = Aite[0];
        AllSpeed[1] = AiteSpeed[0];

        // 排列數值 (照速度降冪)
        for (int i = 0; i < Player.Length; i++)
        {
            if (PlayerSpeed[i] < PlayerSpeed[i + 1])
            {
                a = Player[i + 1];
                Player[i + 1] = Player[i];
                Player[i] = a;
                b = PlayerSpeed[i + 1];
                PlayerSpeed[i + 1] = PlayerSpeed[i];
                PlayerSpeed[i] = b;
            }
        }
        for (int k = 0; k < Aite.Length; k++)
        {
            if (AiteSpeed[k] < AiteSpeed[k + 1])
            {
                a = Aite[k + 1];
                Aite[k + 1] = Aite[k];
                Aite[k] = a;
                b = AiteSpeed[k + 1];
                AiteSpeed[k + 1] = AiteSpeed[k];
                AiteSpeed[k] = b;
            }
        }
        for (int i = 0; i < All.Length; i++)
        {
            if (AllSpeed[i] < AllSpeed[i + 1])
            {
                a = All[i + 1];
                All[i + 1] = All[i];
                All[i] = a;
                b = AllSpeed[i + 1];
                AllSpeed[i + 1] = AllSpeed[i];
                AllSpeed[i] = b;
            }
        }
    }

    // 一回合
    IEnumerator Round()
    {
        yield return new WaitForSeconds(1);

        for (int i = 0;i < All.Length;i++)
        {
            // 等字跑完
            yield return ButtonControl.buttonUsing == false;

            // 如果是玩家動作
            if (Mathf.Floor(All[i] / 10) == 0)
            {

            }

            // 如果是電腦動作
            if (Mathf.Floor(All[i] / 10) != 1)
            {

            }
        }
        intRound++;
    }

    //void OverallControlStart()
    //{
    //    // 輸入數值
    //    Player[0] = DominateInformation.name;
    //    PlayerHP[0] = DominateInformation.MaxHP;
    //    PlayerSpeed[0] = DominateInformation.Speed;
    //    Aite[0] = WoodenDragonInformation.name;
    //    AiteHP[0] = WoodenDragonInformation.MaxHP;
    //    AiteSpeed[0] = WoodenDragonInformation.Speed;
    //    All[0] = Player[0];
    //    AllHP[0] = PlayerHP[0];
    //    AllSpeed[0] = PlayerSpeed[0];
    //    All[1] = Aite[0];
    //    AllHP[1] = AiteHP[0];
    //    AllSpeed[1] = AiteSpeed[0];

    //    // 排列數值 (照速度降冪)
    //    for (int i = 0; i < Player.Length; i++)
    //    {
    //        if (PlayerSpeed[i] < PlayerSpeed[i + 1])
    //        {
    //            a = Player[i + 1];
    //            Player[i + 1] = Player[i];
    //            Player[i] = a;
    //            b = PlayerHP[i + 1];
    //            PlayerHP[i + 1] = PlayerHP[i];
    //            PlayerHP[i] = b;
    //            b = PlayerSpeed[i + 1];
    //            PlayerSpeed[i + 1] = PlayerSpeed[i];
    //            PlayerSpeed[i] = b;
    //        }
    //    }
    //    for (int k = 0; k < Aite.Length; k++)
    //    {
    //        if (AiteSpeed[k] < AiteSpeed[k + 1])
    //        {
    //            a = Aite[k + 1];
    //            Aite[k + 1] = Aite[k];
    //            Aite[k] = a;
    //            b = AiteHP[k + 1];
    //            AiteHP[k + 1] = AiteHP[k];
    //            AiteHP[k] = b;
    //            b = AiteSpeed[k + 1];
    //            AiteSpeed[k + 1] = AiteSpeed[k];
    //            AiteSpeed[k] = b;
    //        }
    //    }
    //    for (int i = 0; i < All.Length; i++)
    //    {
    //        if (AllSpeed[i] < AllSpeed[i + 1])
    //        {
    //            a = All[i + 1];
    //            All[i + 1] = All[i];
    //            All[i] = a;
    //            b = AllHP[i + 1];
    //            AllHP[i + 1] = AllHP[i];
    //            AllHP[i] = b;
    //            b = AllSpeed[i + 1];
    //            AllSpeed[i + 1] = AllSpeed[i];
    //            AllSpeed[i] = b;
    //        }
    //    }
    //}

    //public void PlayerDominate(string name, int HP)
    //{
    //    name = "Dominate";
    //    //ATK = DominateInformation.ATK;
    //    //DEF = DominateInformation.DEF;
    //    //MaxHP = DominateInformation.MaxHP;
    //    //MaxMP = DominateInformation.MaxMP;
    //    //speed = DominateInformation.Speed;
    //    HP = 0;
    //}
}
