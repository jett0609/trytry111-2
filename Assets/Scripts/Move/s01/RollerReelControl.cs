using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class RollerReelControl : MonoBehaviour
{
    public int speed;
    public int maxY, minY;
    void Start()
    {
        
    }


    void Update()
    {
        float s = -Input.GetAxis("Mouse ScrollWheel");
        if (gameObject.transform.position.y >= maxY)
            s = -Mathf.Abs(s);
        if (gameObject.transform.position.y <= minY)
            s = Mathf.Abs(s);
        Vector3 move = new Vector3(0, s * speed * Time.deltaTime, 0);
        gameObject.transform.Translate(move);
    }
}
