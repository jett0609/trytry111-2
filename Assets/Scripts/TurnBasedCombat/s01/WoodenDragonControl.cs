using Scripts.RoleInformation;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WoodenDragonControl : MonoBehaviour
{
    public static int NumberAite = 11;

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
        
    }

    void Update()
    {
        TextHP.text = StringHP + HP;
    }
}
