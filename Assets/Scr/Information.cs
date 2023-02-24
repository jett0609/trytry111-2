using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Information
{
    public bool change = false;

    private int _level = 1;
    public int MaxLEVEL = 50;
    public int LEVEL
    {
        get
        {
            return _level;
        }
        set
        {
            if (value < 1) value = 1;
            if (value > MaxLEVEL) value = MaxLEVEL;
            _level = value;
        }
    }

    private int _hp = 100;
    public int MaxHP = 100;
    public int HP
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

    private int _mp = 100;
    public int MaxMP = 100;
    public int MP
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

    private int _sp = 0;
    public int SP
    {
        get
        {
            return _sp;
        }
        set
        {
            if (value < 0) value = 0;
            if (value > 100) value = 100;
            _sp = value;
        }
    }

    private int _atk = 100;
    public int MaxATK = 100;
    public int ATK
    {
        get
        {
            return _atk;
        }
        set
        {
            if (value < 1) value = 1;
            if (value > MaxATK) value = MaxATK;
            _atk = value;
        }
    }

    private int _def = 100;
    public int MaxDEF = 100;
    public int DEF
    {
        get
        {
            return _def;
        }
        set
        {
            if (value < 1) value = 1;
            if (value > MaxDEF) value = MaxDEF;
            _def = value;
        }
    }

    private int _mind = 100;
    public int MaxMIND = 100;
    public int MIND
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

    private int _speed = 100;
    public int MaxSPEED = 100;
    public int SPEED
    {
        get
        {
            return _speed;
        }
        set
        {
            if (value < 1) value = 1;
            if (value > MaxSPEED) value = MaxSPEED;
            _speed = value;
        }
    }
}
