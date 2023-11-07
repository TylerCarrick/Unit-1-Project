using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spikes : MonoBehaviour
{
    public Transform respawnPoint;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == "Player")
        {
            //Destroy(other.gameObject);

            other.gameObject.GetComponent<Transform>().position = respawnPoint.transform.position;

        }
    }
}