using Scripts.RoleInformation;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public string StringHP;
    public Text TextHP;
    int MaxHP;
    public static int HP;
    void Start()
    {
        MaxHP = DominateInformation.MaxHP;
        HP = DominateInformation.MaxHP;
        OverallControl.PlayerSpeed[0] = DominateInformation.Speed;
    }

    void Update()
    {
        TextHP.text = StringHP + HP;
    }
}
