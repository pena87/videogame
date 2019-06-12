using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player1 : MonoBehaviour
{
    public Rigidbody2D cerditoRB;
    public float walkingSpeed;
    public float jumpSpeed;
    //public float maxvelovidad;

    // Start is called before the first frame update
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            cerditoRB.velocity += jumpSpeed * Vector2.up;

        }



        //float mover = Input.GetAxis("Horizontal");
        //cerditoRB.velocity = new Vector2(mover * maxvelovidad, cerditoRB.velocity.y);
    }
}
