using Scripts.RoleInformation;
using System.Buffers.Text;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

// �]���b���P��Ƨ��A�ҥH�n�R�W�Ŷ�
namespace Scripts.TurnBasedCombat.s01
{
    public class ButtonControl : MonoBehaviour
    {
        public static bool buttonUsing = false;
        //public GameObject button;
        //public GameObject talk;
        //public Button buttonTalk;
        //public Text textTalk;
        //public string[] aTalk;
        //public Button yourButton;
        //int Click01, Click02, player, aite, Damage;
        public GameObject Button1On, Button1Off, Button2On, Button2Off, Button3On, Button3Off, Button4On, Button4Off, Button5On, Button5Off;
        //public Sprite AttackOn, AttackOff,SkillOn,SkillOff,ItemOn,ItemOff,EquipOn,EquipOff,FleeOn,FleeOff;

        void Start()
        {
            //Button btn = yourButton.GetComponent<Button>();
            //btn.onClick.AddListener(MouseDownOne);
        }

        public void Attack()
        {
            if (buttonUsing == false)
            {
                buttonUsing = true;

                Button1Off.SetActive(true);

                int damage = DominateControl.ATK - WoodenDragonControl.DEF;

                //aTalk = new string[3];
                //aTalk[0] = "�ϥΤF�����C";
                //aTalk[1] = "�y���F" + damage + "�ˮ`�C";

                WoodenDragonControl.HP -= damage;

                MouseDownTwo();
                Button1Off.SetActive(false);
                OverallControl.intRound++;
            }
        }

        public void Skill()
        {
            if (buttonUsing == false)
            {
                buttonUsing = true;

                //aTalk = new string[2];
                //aTalk[0] = "�ϥΤF�ޯ�C";



                MouseDownTwo();
                OverallControl.intRound++;
            }
        }

        public void Prop()
        {
            if (buttonUsing == false)
            {
                buttonUsing = true;

                //aTalk = new string[2];
                //aTalk[0] = "�ϥΤF�D��C";


                MouseDownTwo();
            }
        }

        public void Equip()
        {
            if (buttonUsing == false)
            {
                buttonUsing = true;

                //aTalk = new string[2];
                //aTalk[0] = "�ϥΤF�˳ơC";



                MouseDownTwo();
            }
        }


        //public void MouseDownOne()
        //{
        //    StartCoroutine(IEBoolUsing());

        //    IEnumerator IEBoolUsing()
        //    {

        //    }

        //    talk.SetActive(true);
        //    //textTalk.text = aTalk[0];
        //    //MouseDown();
        //    //Button btn2 = buttonTalk.GetComponent<Button>();
        //    //btn2.onClick.AddListener(MouseDownTwo);
        //}

        public void MouseDownTwo()
        {
            StartCoroutine(IETalk());

            IEnumerator IETalk()
            {
                //talk.SetActive(true);

                //for (int i = 0; i < aTalk.Length; i++)
                //{
                //    textTalk.text = aTalk[i];
                //    yield return new WaitForSeconds(1.5f);
                //}
                yield return new WaitForSeconds(1.5f);
                buttonUsing = false;
            }

            //Click01++;
            //int e;
            //e = Click01 % (aTalk.Length);
            //if (e == 0)
            //{
            //    talk.SetActive(false);
            //    Click02 = 0;
            //    Click01 = 0;
            //    player++;
            //}
            //else
            //{
            //    talk.SetActive(true);
            //    textTalk.text = aTalk[Click02];
            //    Click02++;
            //}
        }

        //public void MouseDown()
        //{
        //    aTalk[0] = OverallControl.Player[player] + aTalk[0];
        //    if (gameObject.name == "Button01")
        //        Attack();
        //    if (gameObject.name == "Button02")
        //        Skill();
        //    if (gameObject.name == "Button03")
        //        Prop();
        //    if (gameObject.name == "Button04")
        //        Equip();
        //    if (gameObject.name == "ButtonRun")
        //        Run();
        //    //ButtonControlDominateInformation.ATK
        //    //aTalk[1] = aTalk[1];
        //}


        //public void Run()
        //{
        //    if (OverallControl.buttonUsing == false)
        //    {
        //        OverallControl.buttonUsing = true;

        //        talk.SetActive(true);

        //        aTalk[0] = "�ϥΤF�k�]�C";
        //        aTalk[1] = "�k�]���\�C";



        //        MouseDownTwo();
        //    }
        //}
    }
}

