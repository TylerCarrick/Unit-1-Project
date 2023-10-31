using System.Collections;
using System.Collections.Generic;
using Unity.Burst.CompilerServices;
using UnityEditor;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] Transform groundCheckCollider;
    [SerializeField] LayerMask groundLayer;
    bool isGrounded = false;
    Helper helper;
    public GameObject weapon;
    Animator anim;
    public Rigidbody2D rb;
    SpriteRenderer sr;
    void Start()
    {
        helper = gameObject.AddComponent<Helper>();
        sr = GetComponent<SpriteRenderer>();
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }



    void Update()
    {
        sr.flipX = false;
        int speed = 5;
        int jumpAmount = 6;
        anim.SetBool("Run", false);
        anim.SetBool("Jump", false);
        bool hit;
      
        if (Input.GetKeyDown("space"))
        {
            hit = helper.ExtendedRayCollisionCheck(0, 0.1f);
            if (hit == true)
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



            int moveDirection = 1;
            if (Input.GetButtonDown("Fire1"))
            {
                GameObject clone;
                clone = Instantiate(weapon, transform.position, transform.rotation);
                Rigidbody2D rb = clone.GetComponent<Rigidbody2D>();
                rb.velocity = new Vector3(15 * moveDirection, 0, 0);
                rb.transform.position = new Vector3(transform.position.x, transform.position.y +
                2, transform.position.z + 1);
            }











        }
    }
}
