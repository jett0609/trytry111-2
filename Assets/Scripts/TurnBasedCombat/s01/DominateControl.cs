using Scripts.RoleInformation;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//public class DominateInformation
//{
//    public static int NumberPlayer = 1;

//    public static string name = "Dominate";

//    public static int MaxHP = 265;

//    public static int MaxMP = 214;

//    public static int ATK = 145;

//    public static int DEF = 200;

//    public static int Speed = 50;

//    //public static int _mind = 100;
//    //public static int MaxMIND = 100;
//    //public static int MIND
//    //{
//    //    get
//    //    {
//    //        return _mind;
//    //    }
//    //    set
//    //    {
//    //        if (value < 1) value = 1;
//    //        if (value > MaxMIND) value = MaxMIND;
//    //        _mind = value;
//    //    }
//    //}
//}

public class DominateControl : MonoBehaviour
{
    public static int NumberPlayer = 1;

    public static string name = "Dominate";

    public static int MaxHP = 265;

    public static int MaxMP = 214;

    public static int ATK = 145;

    public static int DEF = 200;

    public static int Speed = 50;
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
