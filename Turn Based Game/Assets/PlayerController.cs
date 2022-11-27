using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : TurnTakerController
{
   public Rigidbody rb;
   private Vector3 speed;
   [HideInInspector] public float zspeed = 10, mousey, mousex;
    void Start()
    {
        GameManager.pc = this;
    }

    // Update is called once per frame
    void Update()
    {
        PlayerMovement();
    }
    
    void PlayerMovement(){
        
        mousey = Mathf.Clamp(mousey, -90, 90);
        mousex = Input.GetAxis("Mouse X") * GameManager.gm.sensitive;
        mousey = -Input.GetAxis("Mouse Y") * GameManager.gm.sensitive;
        transform.Rotate(0, mousex, 0);
        
        Vector3 vel = new Vector3(0, 0, 0);
        speed = new Vector3(1.5f, 0, 0);
        Vector3 sidespeed = transform.right * zspeed;
        Vector3 fowardspeed = transform.forward * zspeed;

        if (Input.GetKey(KeyCode.W))
        {
Debug.Log("i am moving");
            vel += fowardspeed;
        }

        if (Input.GetKey(KeyCode.S))
        {
            vel += -fowardspeed;
        }

        if (Input.GetKey(KeyCode.A))
        {
            vel += -sidespeed;
        }

        if (Input.GetKey(KeyCode.D))
        {
            vel += sidespeed;
        }

       

        vel = Vector3.Lerp(rb.velocity, vel, GameManager.gm.walkdelay * Time.deltaTime);
        rb.velocity = vel;
    
    }
}
