using Scripts.RoleInformation;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Aite : MonoBehaviour
{
    public string StringHP;
    public Text TextHP; 
    int MaxHP;
    public static int HP;
    void Start()
    {
        MaxHP = WoodenDragonInformation.MaxHP;
        HP = WoodenDragonInformation.MaxHP;
        
    }

    void Update()
    {
        TextHP.text = StringHP + HP;
    }
}
