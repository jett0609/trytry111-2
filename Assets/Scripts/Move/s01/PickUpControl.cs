using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 因為在不同資料夾，所以要命名空間
namespace Scripts.Move.s01
{
    public class PickUpControl : MonoBehaviour
    {
        bool PlayerBool = false;
        void Start()
        {
            
        }

        void Update()
        {
            // 如果按了Z
            if (Input.GetKeyDown(KeyCode.Z)|| Input.GetKeyDown(KeyCode.Return))
            {
                // 如果在撿的範圍
                if (PlayerBool == true)
                {
                    // A+1且物品消失
                    PropsInformation.A += 1;
                    gameObject.SetActive(false);
                }
            }
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.tag == "Player")
            {
                PlayerBool = true;
            }
        }

        private void OnTriggerExit(Collider other)
        {
            if (other.gameObject.tag == "Player")
            {
                PlayerBool = false;
            }
        }
    }
}