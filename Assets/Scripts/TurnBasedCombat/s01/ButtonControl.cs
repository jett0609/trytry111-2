using Scripts.RoleInformation;
using System.Buffers.Text;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

// 因為在不同資料夾，所以要命名空間
namespace Scripts.TurnBasedCombat.s01
{
    public class ButtonControl : MonoBehaviour
    {
        public static bool buttonUsing = false;
        //public GameObject button;
        public GameObject talk;
        //public Button buttonTalk;
        public Text textTalk;
        public string[] aTalk;
        //public Button yourButton;
        //int Click01, Click02, player, aite, Damage;
        public GameObject Button1, Button2, Button3, Button4, Button5;
        public Sprite AttackOn, AttackOff,SkillOn,SkillOff,ItemOn,ItemOff,EquipOn,EquipOff,FleeOn,FleeOff;

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

                Image sp = Button1.gameObject.GetComponent<Image>();
                sp.sprite = AttackOff;

                int damage = DominateInformation.ATK - WoodenDragonInformation.DEF;

                aTalk = new string[3];
                aTalk[0] = "使用了攻擊。";
                aTalk[1] = "造成了" + damage + "傷害。";

                Aite.HP -= damage;

                MouseDownTwo();
                sp.sprite = AttackOn;
                OverallControl.intRound++;
            }
        }

        public void Skill()
        {
            if (buttonUsing == false)
            {
                buttonUsing = true;

                aTalk = new string[2];
                aTalk[0] = "使用了技能。";



                MouseDownTwo();
                OverallControl.intRound++;
            }
        }

        public void Prop()
        {
            if (buttonUsing == false)
            {
                buttonUsing = true;

                aTalk = new string[2];
                aTalk[0] = "使用了道具。";



                MouseDownTwo();
            }
        }

        public void Equip()
        {
            if (buttonUsing == false)
            {
                buttonUsing = true;

                aTalk = new string[2];
                aTalk[0] = "使用了裝備。";



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

                for (int i = 0; i < aTalk.Length; i++)
                {
                    textTalk.text = aTalk[i];
                    yield return new WaitForSeconds(1.5f);
                }

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

        //        aTalk[0] = "使用了逃跑。";
        //        aTalk[1] = "逃跑成功。";



        //        MouseDownTwo();
        //    }
        //}
    }
}

