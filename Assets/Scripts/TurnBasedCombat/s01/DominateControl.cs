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

    public GameObject m_Image;
    public Vector3 m_ImagePlace1, m_ImagePlace2, m_ImagePlace3, m_ImagePlace4;
    public GameObject m_Image2;
    public Vector3 m_Image2Place1 = new Vector3(120, -120, 0), m_Image2Place2 = new Vector3(120, -280, 0), m_Image2Place3 = new Vector3(120, -440, 0), m_Image2Place4 = new Vector3(120, -600, 0);
    //public GameObject m_Icon;
    //public GameObject m_Icon2;
    //public Vector3 m_Icon2Place1 = new Vector3(1016, -900, 0), m_Icon2Place2 = new Vector3(1256, -900, 0), m_Icon2Place3 = new Vector3(1496, -900, 0), m_Icon2Place4 = new Vector3(1736, -900, 0);

    void Start()
    {
        HP = MaxHP;
        if (OverallControl.Player1[1] == 0)
        {
            //块计(Speed, HP, MP, ATK, DEF)
            OverallControl.Player1[1] = NumberPlayer;
            OverallControl.Player1[2] = Speed;
            OverallControl.Player1[3] = HP;
            OverallControl.Player1[4] = 0;
            OverallControl.Player1[5] = ATK;
            OverallControl.Player1[6] = DEF;
            m_Image.transform.position = m_ImagePlace1;
            m_Image2.transform.position = m_Image2Place1;
        }
        else if (OverallControl.Player2[1] == 0)
        {
            //块计(Speed, HP, MP, ATK, DEF)
            OverallControl.Player2[1] = NumberPlayer;
            OverallControl.Player2[2] = Speed;
            OverallControl.Player2[3] = HP;
            OverallControl.Player2[4] = 0;
            OverallControl.Player2[5] = ATK;
            OverallControl.Player2[6] = DEF;
            m_Image.transform.position = m_ImagePlace2;
            m_Image2.transform.position = m_Image2Place2;
        }
        else if (OverallControl.Player3[1] == 0)
        {
            //块计(Speed, HP, MP, ATK, DEF)
            OverallControl.Player3[1] = NumberPlayer;
            OverallControl.Player3[2] = Speed;
            OverallControl.Player3[3] = HP;
            OverallControl.Player3[4] = 0;
            OverallControl.Player3[5] = ATK;
            OverallControl.Player3[6] = DEF;
            m_Image.transform.position = m_ImagePlace3;
            m_Image2.transform.position = m_Image2Place3;
        }
         else
        {
            //块计(Speed, HP, MP, ATK, DEF)
            OverallControl.Player4[1] = NumberPlayer;
            OverallControl.Player4[2] = Speed;
            OverallControl.Player4[3] = HP;
            OverallControl.Player4[4] = 0;
            OverallControl.Player4[5] = ATK;
            OverallControl.Player4[6] = DEF;
            m_Image.transform.position = m_ImagePlace4;
            m_Image2.transform.position = m_Image2Place4;
        }
    }
    void Update()
    {
        TextHP.text = StringHP + HP;
    }
}

