using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player1 : MonoBehaviour
{
    Rigidbody2D cerditoRB;
    public float maxVelocidad;
    public float walkingSpeed;
    public float jumpSpeed;

    bool voltearCerdo = true;
    SpriteRenderer cerdoRender; 
    

    // Start is called before the first frame update
    void Start()
    {
        cerditoRB = GetComponent<Rigidbody2D>();
        cerdoRender = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        float mover = Input.GetAxis("Horizontal");

        if (Input.GetKeyDown(KeyCode.UpArrow))
        { // x-axis movement
            cerditoRB.velocity += jumpSpeed * Vector2.up;
        }

        { // x-axis movement
            var v = cerditoRB.velocity;
            var speed = 0f;
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                speed += -walkingSpeed;
            }
            if (Input.GetKey(KeyCode.RightArrow))
            {
                speed += walkingSpeed;
            }
            v.x = speed;
            cerditoRB.velocity = v;
        }

        if (mover > 0 && !voltearCerdo) {

            Voltear();
        }
        else if (mover < 0 && voltearCerdo) {

            Voltear();
        }



       
    }

    void Voltear()
    {

        voltearCerdo = !voltearCerdo;
        cerdoRender.flipX = !cerdoRender.flipX;
    }

}
