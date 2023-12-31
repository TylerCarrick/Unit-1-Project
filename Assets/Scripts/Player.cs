using System.Collections;
using System.Collections.Generic;
using Unity.Burst.CompilerServices;
using UnityEditor;
using UnityEngine;

public class Player : MonoBehaviour
{
    public HeathBar healthBar;
    public int maxHealth = 5;
    public int currentHealth;
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
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }



    void Update()
    {
       
       
        
       
        
        int speed = 10;
        int jumpAmount = 8;
        anim.SetBool("Run", false);
        anim.SetBool("Jump", false);


        if (helper.ExtendedRayCollisionCheck(0, 0.1f) == true)
        {
            if (Input.GetKeyDown("space"))
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
            if (Input.GetKeyDown("q"))
            {
                GameObject clone;
                clone = Instantiate(weapon, transform.position, transform.rotation);
                Rigidbody2D rb = clone.GetComponent<Rigidbody2D>();
                rb.velocity = new Vector3(15 * moveDirection, 0, 0);
                rb.transform.position = new Vector3(transform.position.x +0.5f, transform.position.y, transform.position.z + 1);
            }



        }
        if (currentHealth <= 0)
        {
            Destroy(gameObject);
        }


    }

   


    public void damagePlayer(int damage)
    {
        currentHealth -= damage;

    }


}

