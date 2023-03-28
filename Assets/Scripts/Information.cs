using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Information
{
    public static float[] x = new float[8];
    public static float[] z = new float[8];

    public static int _hp = 265;
    public static int MaxHP = 265;
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

    public static int _mp = 0;
    public static int MaxMP = 214;
    public static int MP
    {
        get
        {
            return _mp;
        }
        set
        {
            if (value < 0) value = 0;
            if (value > MaxMP) value = MaxMP;
            _mp = value;
        }
    }

    public static int ATK = 145;

    public static int DEF = 200;

    public static int _mind = 100;
    public static int MaxMIND = 100;
    public static int MIND
    {
        get
        {
            return _mind;
        }
        set
        {
            if (value < 1) value = 1;
            if (value > MaxMIND) value = MaxMIND;
            _mind = value;
        }
    }

    public static int Speed = 50;
}
