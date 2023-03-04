using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Talk : MonoBehaviour
{
    public Text textTalk;
    public Button buttonTalk;
    public string talk = "¾Ô°«¶}©l¡C";
    public GameObject gameObjectTalk;
    void Start()
    {
        textTalk.text = talk;
        Button btn = buttonTalk.GetComponent<Button>();
        btn.onClick.AddListener(Mousedownone);
    }

    
    void Update()
    {
        
    }

    public void Mousedownone()
    {
        gameObjectTalk.SetActive(false);
    }
}
