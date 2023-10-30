using System.Collections;
using System.Collections.Generic;
using Unity.Burst.CompilerServices;
using UnityEditor;
using UnityEngine;

public class Player : MonoBehaviour
{
    Animator anim;
    public Rigidbody2D rb;
    SpriteRenderer sr;
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }



    void Update()
    {
        sr.flipX = false;
        int speed = 5;
        int jumpAmount = 4;
        anim.SetBool("Run", false);
        anim.SetBool("Jump", false);

        if (Input.GetKeyDown("space"))
         {


            {
                rb.AddForce(Vector2.up * jumpAmount, ForceMode2D.Impulse);
                anim.SetBool("Jump", true);
            }
            
        
         }

        if (Input.GetKeyDown("e"))
        {
            print("player pressed attack");
            anim.SetTrigger("Attack");
        }

        DoRun();

            void DoRun()
            {
                if (Input.GetKey(KeyCode.A) == true)
                {

                    transform.position = new Vector2(transform.position.x - (speed * Time.deltaTime), transform.position.y);
                    anim.SetBool("Run", true);
                    sr.flipX = true;
                }



                if (Input.GetKey(KeyCode.D) == true)
                {

                    transform.position = new Vector2(transform.position.x + (speed * Time.deltaTime), transform.position.y);
                    anim.SetBool("Run", true);
                    sr.flipX = false;
                }











            }

        
    }
}
