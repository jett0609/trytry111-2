using Scripts.RoleInformation;
using System.Buffers.Text;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// 因為在不同資料夾，所以要命名空間
namespace Scripts.TurnBasedCombat.s01
{
    public class ButtonControl : MonoBehaviour
    {
        //public GameObject button;
        public GameObject talk;
        public Button buttonTalk;
        public Text textTalk;
        public string[] aTalk;
        public Button yourButton;
        int Click01, Click02, player, aite, Damage;

        void Start()
        {
            Button btn = yourButton.GetComponent<Button>();
            btn.onClick.AddListener(MouseDownOne);
        }

        public void MouseDownOne()
        {
            talk.SetActive(true);
            textTalk.text = aTalk[0];
            MouseDown();
            Button btn2 = buttonTalk.GetComponent<Button>();
            btn2.onClick.AddListener(MouseDownTwo);
        }

        public void MouseDownTwo()
        {
            Click01++;
            int e;
            e = Click01 % (aTalk.Length);
            if (e == 0)
            {
                talk.SetActive(false);
                Click02 = 0;
                Click01 = 0;
                player++;
            }
            else
            {
                talk.SetActive(true);
                textTalk.text = aTalk[Click02];
                Click02++;
            }
        }

        public void MouseDown()
        {
            aTalk[0] = OverallControl.Player[player] + aTalk[0];
            if (gameObject.name == "Button01")
                Attack();
            if (gameObject.name == "Button02")
                Skill();
            if (gameObject.name == "Button03")
                Prop();
            if (gameObject.name == "Button04")
                Equip();
            if (gameObject.name == "ButtonRun")
                Run();
            //ButtonControlDominateInformation.ATK
            //aTalk[1] = aTalk[1];
        }

        void Attack()
        {
            //Damage = OverallControl.Player - 
            // interface

            OverallControl.Round++;
        }

        void Skill()
        {

            OverallControl.Round++;
        }

        void Prop()
        {

        }

        void Equip()
        {

        }

        void Run()
        {

        }
    }
}

