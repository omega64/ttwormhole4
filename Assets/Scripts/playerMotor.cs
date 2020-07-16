using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class playerMotor : MonoBehaviour
{
    CharacterController controller;
    Vector3 moveVector;
    float speed = 10.0f;
    public bool isDead = false;
    
     // Start is called before the first frame update
     void Start()
    {
        controller=GetComponent<CharacterController>();
        
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isDead)
        {
            return;
        }

       


        moveVector.x = Input.GetAxisRaw("Horizontal") * speed;
        moveVector.y = Input.GetAxisRaw("Vertical") * speed;
        moveVector.z = speed;

        if ((-9.7 >= transform.position.x) || transform.position.x >= 9.7)
        {
            moveVector.x = 0;
        }
        if ((-9.7 >= transform.position.y) || transform.position.y >= 9.7)
        {
            moveVector.y = 0;
        }
        

       
        controller.Move(moveVector * Time.deltaTime);
    }
    public void SetSpeed(float modifier)
    {
        speed = 10.0f + modifier;
    }
   
    public void Death()
    {
        isDead = true;
        GetComponent<Score>().OnDeath();
    }
}
