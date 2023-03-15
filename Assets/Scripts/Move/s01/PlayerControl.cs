using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerControl : MonoBehaviour
{
    public GameObject player;
    public GameObject storeUI;
    CharacterController controller;
    public float speed = 10;
    float time = 0;
    public float randomMax, randomMin;
    public string Place;
    public string Aide;
    bool StoreBool = false;
    //bool PickUpBool = false;
    int e = 0;
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        Vector3 dir = new Vector3(h, 0, v);

        // �p�G������
        if (dir.magnitude > 0.1f)
        {
            // ����
            float faceAngle = Mathf.Atan2(h, v) * Mathf.Rad2Deg;
            player.transform.rotation = Quaternion.Euler(0, faceAngle, 0);
            //Quaternion targetRotation = Quaternion.Euler(0, faceAngle, 0);
            //transform.rotation = Quaternion.Lerp(transform.rotation, targetRotation, 0.3f);

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

        // ���� (x,z)
        Vector3 move = dir * speed * Time.deltaTime;
        controller.Move(move);

        // �p�G���FE
        if (Input.GetKeyDown(KeyCode.E))
        {
            // �p�G�b�ө��d��
            if (StoreBool == true)
            {
                e += 1;
                int _e = e % 2;
                switch (_e)
                {
                    // ���ө�
                    case 0:
                        storeUI.SetActive(false);
                        break;
                    // �}�ө�
                    case 1:
                        storeUI.SetActive(true);
                        break;
                }
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

        // �p�G�i�J�ӤH����ܽd��
        if (other.gameObject.tag == "Store")
        {
            StoreBool= true;
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
        // �p�G���}�ӤH����ܽd��
        if (other.gameObject.tag == "Store")
        {
            StoreBool = false;
        }

        //if (other.gameObject.tag == "PickUp")
        //{
        //    PickUpBool = false;
        //}
    }
}
