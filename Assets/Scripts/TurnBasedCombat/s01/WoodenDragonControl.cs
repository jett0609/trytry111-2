using Scripts.RoleInformation;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WoodenDragonControl : MonoBehaviour
{
    public static int NumberEnemy = 11;

    public static string name = "WoodenDragon";

    public static int MaxHP = 3620;

    public static int MaxMP = 213;

    public static int ATK = 263;

    public static int DEF = 83;

    public static int Speed = 51;

    public string StringHP;
    public Text TextHP;
    public static int _hp;
    public static int HP
    {
        get
        {
            return _hp;
        }
        set
        {
            if (value < 0) value = 0;
            if (value > MaxHP) value = MaxHP;
            _hp = value;
        }
    }
    void Start()
    {
        HP = MaxHP;
        if (OverallControl.Player5[1] == 0)
        {
            //块计(Speed, HP, MP, ATK, DEF)
            OverallControl.Player5[1] = NumberEnemy;
            OverallControl.Player5[2] = Speed;
            OverallControl.Player5[3] = HP;
            OverallControl.Player5[4] = 0;
            OverallControl.Player5[5] = ATK;
            OverallControl.Player5[6] = DEF;
        }
        else if (OverallControl.Player6[1] == 0)
        {
            //块计(Speed, HP, MP, ATK, DEF)
            OverallControl.Player6[1] = NumberEnemy;
            OverallControl.Player6[2] = Speed;
            OverallControl.Player6[3] = HP;
            OverallControl.Player6[4] = 0;
            OverallControl.Player6[5] = ATK;
            OverallControl.Player6[6] = DEF;
        }
        else if (OverallControl.Player7[1] == 0)
        {
            //块计(Speed, HP, MP, ATK, DEF)
            OverallControl.Player7[1] = NumberEnemy;
            OverallControl.Player7[2] = Speed;
            OverallControl.Player7[3] = HP;
            OverallControl.Player7[4] = 0;
            OverallControl.Player7[5] = ATK;
            OverallControl.Player7[6] = DEF;
        }
        else
        {
            //块计(Speed, HP, MP, ATK, DEF)
            OverallControl.Player8[1] = NumberEnemy;
            OverallControl.Player8[2] = Speed;
            OverallControl.Player8[3] = HP;
            OverallControl.Player8[4] = 0;
            OverallControl.Player8[5] = ATK;
            OverallControl.Player8[6] = DEF;
        }
    }

    void Update()
    {
        TextHP.text = StringHP + HP;
    }
}
