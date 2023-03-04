using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapControl : MonoBehaviour
{
    //-25~25
    float _x, _y;
    float X
    {
        get
        {
            return _x;
        }
        set
        {
            if (value > 23) value = 23;
            if (value < -23) value = -23;
            _x = value;
        }
    }
    float Y
    {
        get
        {
            return _y;
        }
        set
        {
            if (value > 25) value = 25;
            if (value < -25) value = -25;
            _y = value;
        }
    }
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }
}
