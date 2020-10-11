using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D myRB;

    //movement
    public float maxSpeed = 8;

    // Start is called before the first frame update
    void Start()
    {
        myRB = GetComponent<Rigidbody2D> ();
    }

    // Update is called once per frame
    void Update()
    {
        float move = Input.getAxis("Horizontal");
    
        myRB.velocity = new Vector2(move * maxSpeed, myRB.velocity.y);
    }

}
