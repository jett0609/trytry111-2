using Scripts.RoleInformation;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateControl : MonoBehaviour
{
    int player = DominateControl.NumberPlayer;
    int r = 11;
    int[] x, y;
    //int r1 = Random.Range(21, 29);
    //int r2 = Random.Range(21, 29);
    //int r3 = Random.Range(21, 29);
    public GameObject[] fightGameObjects = new GameObject[20];
    void Start()
    {
        Instantiate(fightGameObjects[r]);
        Instantiate(fightGameObjects[player]);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
