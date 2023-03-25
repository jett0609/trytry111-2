using Scripts.RoleInformation;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OverallControl : MonoBehaviour
{
    int b;
    string a;
    public static string[] Player;
    public static int[] PlayerHP;
    public static int[] PlayerSpeed;
    public static string[] Aite;
    public static int[] AiteHP;
    public static int[] AiteSpeed;
    public static string[] All;
    public static int[] AllHP;
    public static int[] AllSpeed;
    public static int Round;

    void Start()
    {
        OverallControlStart();

        //Player[0] = DominateInformation.name;
        //PlayerHP[0] = DominateInformation.MaxHP;
        //Aite[0] = WoodenDragonInformation.name;
        //AiteHP[0] = WoodenDragonInformation.MaxHP;
    }

    void Update()
    {
        
    }

    void OverallControlStart()
    {
        // 輸入數值
        Player[0] = DominateInformation.name;
        PlayerHP[0] = DominateInformation.MaxHP;
        PlayerSpeed[0] = DominateInformation.Speed;
        Aite[0] = WoodenDragonInformation.name;
        AiteHP[0] = WoodenDragonInformation.MaxHP;
        AiteSpeed[0] = WoodenDragonInformation.Speed;
        All[0] = Player[0];
        AllHP[0] = PlayerHP[0];
        AllSpeed[0] = PlayerSpeed[0];
        All[1] = Aite[0];
        AllHP[1] = AiteHP[0];
        AllSpeed[1] = AiteSpeed[0];

        // 排列數值 (照速度降冪)
        for (int i = 0; i < Player.Length; i++)
        {
            if (PlayerSpeed[i] < PlayerSpeed[i + 1])
            {
                a = Player[i + 1];
                Player[i + 1] = Player[i];
                Player[i] = a;
                b = PlayerHP[i + 1];
                PlayerHP[i + 1] = PlayerHP[i];
                PlayerHP[i] = b;
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
                b = AiteHP[k + 1];
                AiteHP[k + 1] = AiteHP[k];
                AiteHP[k] = b;
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
                b = AllHP[i + 1];
                AllHP[i + 1] = AllHP[i];
                AllHP[i] = b;
                b = AllSpeed[i + 1];
                AllSpeed[i + 1] = AllSpeed[i];
                AllSpeed[i] = b;
            }
        }
    }

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
