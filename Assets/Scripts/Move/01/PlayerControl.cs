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

        // 如果有移動
        if (dir.magnitude > 0.1f)
        {
            // 旋轉
            float faceAngle = Mathf.Atan2(h, v) * Mathf.Rad2Deg;
            player.transform.rotation = Quaternion.Euler(0, faceAngle, 0);
            //Quaternion targetRotation = Quaternion.Euler(0, faceAngle, 0);
            //transform.rotation = Quaternion.Lerp(transform.rotation, targetRotation, 0.3f);

            // 計時
            time += Time.deltaTime;
            float randomTime = Random.Range(randomMin, randomMax);
            if (time > randomTime)
            {
                // 遇見怪物
                SceneManager.LoadScene(Aide);
                time = 0;
            }
        }

        // 移動 (x,z)
        Vector3 move = dir * speed * Time.deltaTime;
        controller.Move(move);

        // 如果按了E
        if (Input.GetKeyDown(KeyCode.E))
        {
            // 如果在商店範圍
            if (StoreBool == true)
            {
                e += 1;
                int _e = e % 2;
                switch (_e)
                {
                    // 關商店
                    case 0:
                        storeUI.SetActive(false);
                        break;
                    // 開商店
                    case 1:
                        storeUI.SetActive(true);
                        break;
                }
            }
        }
    }

    //private void OnCollisionEnter(Collision collision)
    //{
    //    // 如果撞到地方就更改關卡
    //    if (collision.gameObject.tag == "Place")
    //    {
    //        SceneManager.LoadScene(Place);
    //    }
    //}

    private void OnTriggerEnter(Collider other)
    {
        // 如果撞到地方就更改關卡
        if (other.gameObject.tag == "Place")
        {
            SceneManager.LoadScene(Place);
        }

        // 如果進入商人的對話範圍
        if (other.gameObject.tag == "Store")
        {
            StoreBool= true;
        }

        //    // 如果撞到敵人就更改關卡
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
        // 如果離開商人的對話範圍
        if (other.gameObject.tag == "Store")
        {
            StoreBool = false;
        }
    }
}
