using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerControl : MonoBehaviour
{
    public GameObject player;
    CharacterController controller;
    public float speed = 10;
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        Vector3 dir = new Vector3(h, 0, v);

        //旋轉
        if (dir.magnitude > 0.1f)
        {
            float faceAngle = Mathf.Atan2(h, v) * Mathf.Rad2Deg;
            player.transform.rotation = Quaternion.Euler(0, faceAngle, 0);
            //Quaternion targetRotation = Quaternion.Euler(0, faceAngle, 0);
            //transform.rotation = Quaternion.Lerp(transform.rotation, targetRotation, 0.3f);
        }

        // 移動 (x,z)
        Vector3 move = dir * speed * Time.deltaTime;
        controller.Move(move);
    }

    public string Place;
    //private void OnCollisionEnter(Collision collision)
    //{
    //    //如果撞到地方就更改關卡
    //    if (collision.gameObject.tag == "Place")
    //    {
    //        SceneManager.LoadScene(Place);
    //    }
    //}
    private void OnTriggerEnter(Collider other)
    {
        //如果撞到地方就更改關卡
        if (other.gameObject.tag == "Place")
        {
            SceneManager.LoadScene(Place);
        }
    }
}
