﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void LButtonDown()
    {
        //左矢印が押された時
        transform.Translate(-3, 0, 0); 
        
    }


    public void RButtonDown()
    {
        transform.Translate(3, 0, 0);
    }
}
