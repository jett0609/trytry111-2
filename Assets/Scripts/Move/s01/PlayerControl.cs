using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerControl : MonoBehaviour
{
    public GameObject player;
    public GameObject storeUI;
    public GameObject saveUI;
    bool UI = false;
    public static int SaveTime = 0;
    CharacterController controller;
    public float speed = 10;
    float time = 0;
    public float randomMax, randomMin;
    public string Place;
    public string Aide;
    //bool PickUpBool = false;
    float h, v;
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        // �p�GUI���@��
        if (UI == false)
        {
            h = Input.GetAxis("Horizontal");
            v = Input.GetAxis("Vertical");
        }

        Vector3 dir = new Vector3(h, 0, v);

        // �p�G������
        if (dir.magnitude > 0.1f)
        {
            // ����
            PlayerRotate();

            // �J��
            MeetMonster();
        }

        // ���� (x,z)
        Vector3 move = dir * speed * Time.deltaTime;
        controller.Move(move);

        // �s�XUI (�ثeSave)
        Save();
    }


    void PlayerRotate()
    {
        // ����
        float faceAngle = Mathf.Atan2(h, v) * Mathf.Rad2Deg;
        player.transform.rotation = Quaternion.Euler(0, faceAngle, 0);
        //Quaternion targetRotation = Quaternion.Euler(0, faceAngle, 0);
        //transform.rotation = Quaternion.Lerp(transform.rotation, targetRotation, 0.3f);
    }

    void MeetMonster()
    {
        // �p��
        time += Time.deltaTime;
        float randomTime = Random.Range(randomMin, randomMax);
        if (time > randomTime)
        {
            // �J���Ǫ�
            SceneManager.LoadScene(Aide);
            time = 0;
        }
    }

    void Save()
    {
        // ���ӭn�O�M�檺�A�ȥB����s��
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            // �O��������
            SaveTime++;
            
            if (SaveTime%2==1)
            {
                saveUI.SetActive(true);
                UI = true;
            }
            else
            {
                saveUI.SetActive(false);
                UI = false;
            }
        }
    }


    //private void OnCollisionEnter(Collision collision)
    //{
    //    // �p�G����a��N������d
    //    if (collision.gameObject.tag == "Place")
    //    {
    //        SceneManager.LoadScene(Place);
    //    }
    //}

    private void OnTriggerEnter(Collider other)
    {
        // �p�G����a��N������d
        if (other.gameObject.tag == "Place")
        {
            SceneManager.LoadScene(Place);
        }


        //if (other.gameObject.tag=="PickUp")
        //{
        //    PickUpBool= true;
        //}

        //    // �p�G����ĤH�N������d
        //    if (other.gameObject.tag == "Aide")
        //    {
        //        SceneManager.LoadScene(Aide);
        //    }
    }

    //private void OnTriggerStay(Collider other)
    //{
    //    if (other.gameObject.tag == "Store")
    //    {
    //        //if (Input.GetKeyDown(KeyCode.E))
    //        //{
    //        //    e += 1;
    //        //    switch (e)
    //        //    {
    //        //        case 0:
    //        //            storeUI.SetActive(false);
    //        //            break;
    //        //        case 1:
    //        //            storeUI.SetActive(true);
    //        //            e = 0;
    //        //            break;
    //        //    }
    //        //}

    //        if (Input.GetKeyDown(KeyCode.E))
    //        {
    //            e += 1;
    //            int _e = e % 2;
    //            switch (_e)
    //            {
    //                case 0:
    //                    storeUI.SetActive(false);
    //                    break;
    //                case 1:
    //                    storeUI.SetActive(true);
    //                    break;
    //            }
    //        }
    //    }
    //}

    private void OnTriggerExit(Collider other)
    {

        //if (other.gameObject.tag == "PickUp")
        //{
        //    PickUpBool = false;
        //}
    }
}
