﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class interactions : MonoBehaviour
{  
    void OnTriggerEnter2D(Collider2D other) {
        print ("Enter");

    }

    void OnTriggerExit2D(Collider2D other) {
        print ("Exit");    
    }


    void OnTriggerStay2D(Collider2D other) {
        print ("MUDA");    
    }
}
