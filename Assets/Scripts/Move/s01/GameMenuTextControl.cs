using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameMenuTextControl : MonoBehaviour
{
    public Text TextItem;
    void Start()
    {
        
    }

    void Update()
    {
        TextItem.text = PropsInformation.stringA + PropsInformation.intA;
    }
}
