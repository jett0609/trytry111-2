using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// �]���b���P��Ƨ��A�ҥH�n�R�W�Ŷ�
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
            // �p�G���FZ
            if (Input.GetKeyDown(KeyCode.Z)|| Input.GetKeyDown(KeyCode.Return))
            {
                // �p�G�b�ߪ��d��
                if (PlayerBool == true)
                {
                    // A+1�B���~����
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