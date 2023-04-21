using Newtonsoft.Json.Linq;
using Scripts.RoleInformation;
using Scripts.TurnBasedCombat.s01;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OverallControl : MonoBehaviour
{
    int whosTurn = 1;
    public static int[] Player1;
    public static int[] Player2;
    public static int[] Player3;
    public static int[] Player4;
    public static int[] Player5;
    public static int[] Player6;
    public static int[] Player7;
    public static int[] Player8;
    int[] A;
    public static int intRound = 1;
    public GameObject allButton;
    public GameObject[] Icon;
    public GameObject[] Icon2;
    public Vector3 m_Icon2Place1 = new Vector3(1016, -900, 0), m_Icon2Place2 = new Vector3(1256, -900, 0), m_Icon2Place3 = new Vector3(1496, -900, 0), m_Icon2Place4 = new Vector3(1736, -900, 0), m_Icon2Place5 = new Vector3(-500, 900, 0);

    void Start()
    {
        StartCoroutine(Overall());
        allButton.SetActive(false);
    }

    void Update()
    {
        
    }

    IEnumerator Overall()
    {
        // 生成順序與位置
        Player1[0] = 1;
        Player2[0] = 2;
        Player3[0] = 3;
        Player4[0] = 4;
        Player5[0] = 5;
        Player6[0] = 6;
        Player7[0] = 7;
        Player8[0] = 8;

        yield return new WaitForSeconds(1);

        // 排列數值 (照速度降冪)
        if (Player1[2] < Player2[2])
        {
            A = Player1;
            Player1 = Player2;
            Player2 = Player1;
        }
        if (Player2[2] < Player3[2])
        {
            A = Player2;
            Player2 = Player3;
            Player3 = Player2;
        }
        if (Player3[2] < Player4[2])
        {
            A = Player3;
            Player3 = Player4;
            Player4 = Player3;
        }
        if (Player4[2] < Player5[2])
        {
            A = Player4;
            Player4 = Player5;
            Player5 = Player4;
        }
        if (Player5[2] < Player6[2])
        {
            A = Player5;
            Player5 = Player6;
            Player6 = Player5;
        }
        if (Player6[2] < Player7[2])
        {
            A = Player6;
            Player6 = Player7;
            Player7 = Player6;
        }
        if (Player7[2] < Player8[2])
        {
            A = Player7;
            Player7 = Player8;
            Player8 = Player7;
        }

        // 生成順序Icon
        Icon[0] = Instantiate(Icon2[Player1[1]], m_Icon2Place1, transform.rotation);
        Icon[1] = Instantiate(Icon2[Player2[1]], m_Icon2Place2, transform.rotation);
        Icon[2] = Instantiate(Icon2[Player3[1]], m_Icon2Place3, transform.rotation);
        Icon[3] = Instantiate(Icon2[Player4[1]], m_Icon2Place4, transform.rotation);
        Icon[4] = Instantiate(Icon2[Player5[1]], m_Icon2Place5, transform.rotation);
        Icon[5] = Instantiate(Icon2[Player6[1]], m_Icon2Place5, transform.rotation);
        Icon[6] = Instantiate(Icon2[Player7[1]], m_Icon2Place5, transform.rotation);
        Icon[7] = Instantiate(Icon2[Player8[1]], m_Icon2Place5, transform.rotation);

        allButton.SetActive(true);
    }

    // 一回合
    IEnumerator Round()
    {
        yield return new WaitForSeconds(1);

        whosTurn = 1;

        for (int i = 0; i < 8; i++)
        {
            // 等字跑完
            yield return ButtonControl.buttonUsing == false;

            // 排順序
            Icon[i].transform.position = m_Icon2Place1;
            Icon[(i + 1) % 8].transform.position = m_Icon2Place2;
            Icon[(i + 2) % 8].transform.position = m_Icon2Place3;
            Icon[(i + 3) % 8].transform.position = m_Icon2Place4;
            Icon[(i - 1 + 8) % 8].transform.position = m_Icon2Place5;

            switch (whosTurn)
            {
                case 1:
                    // 如果是玩家動作
                    if (Player1[0] < 5)
                    {
                        allButton.SetActive(true);

                        yield return ButtonControl.buttonUsing == true;
                    }
                    // 如果是電腦動作
                    else
                    {
                        allButton.SetActive(false);
                    }
                    break;

                case 2:
                    if (Player2[0] < 5)
                    {
                        allButton.SetActive(true);

                        yield return ButtonControl.buttonUsing == true;
                    }
                    else
                    {
                        allButton.SetActive(false);
                    }
                    break;

                case 3:
                    if (Player3[0] < 5)
                    {
                        allButton.SetActive(true);

                        yield return ButtonControl.buttonUsing == true;
                    }
                    else
                    {
                        allButton.SetActive(false);
                    }
                    break;

                 case 4:
                    if (Player4[0] < 5)
                    {
                        allButton.SetActive(true);

                        yield return ButtonControl.buttonUsing == true;
                    }
                    else
                    {
                        allButton.SetActive(false);
                    }
                    break;

                 case 5:
                    if (Player5[0] < 5)
                    {
                        allButton.SetActive(true);

                        yield return ButtonControl.buttonUsing == true;
                    }
                    else
                    {
                        allButton.SetActive(false);
                    }
                    break;

                 case 6:
                    if (Player6[0] < 5)
                    {
                        allButton.SetActive(true);

                        yield return ButtonControl.buttonUsing == true;
                    }
                    else
                    {
                        allButton.SetActive(false);
                    }
                    break;

                 case 7:
                    if (Player7[0] < 5)
                    {
                        allButton.SetActive(true);

                        yield return ButtonControl.buttonUsing == true;
                    }
                    else
                    {
                        allButton.SetActive(false);
                    }
                    break;

                 case 8:
                    if (Player8[0] < 5)
                    {
                        allButton.SetActive(true);

                        yield return ButtonControl.buttonUsing == true;
                    }
                    else
                    {
                        allButton.SetActive(false);
                    }
                    break;
            }
            
            whosTurn++;
        }
        intRound++;
    }
}
