using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpItem : MonoBehaviour
{
    public GameObject gm; 
    private ScoreManager scoreManager;

    private void Start()
    {
       scoreManager = gm.GetComponent<ScoreManager>(); 
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            scoreManager.score += 1f;
            Destroy(gameObject);
        }
        

    }

}
