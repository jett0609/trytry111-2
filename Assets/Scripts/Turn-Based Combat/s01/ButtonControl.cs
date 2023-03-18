using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonControl : MonoBehaviour
{
    //public GameObject button;
    public GameObject talk;
    public Text textTalk;
    public string[] aTalk;
    public Button yourButton;

    void Start()
    {
        Button btn = yourButton.GetComponent<Button>();
        btn.onClick.AddListener(Mousedownone);
    }

    public void Mousedownone()
    {
        talk.SetActive(true);
        textTalk.text = aTalk[0];
    }
}

