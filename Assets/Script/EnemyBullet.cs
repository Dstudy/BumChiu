using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
    public float speed;
    void Update()
    {
        gameObject.transform.position += Vector3.down* Time.deltaTime * speed;
    }

    // private void OnTriggerEnter2D(Collider2D other)
    // {
    //     Destroy(gameObject);
    //     Debug.Log("Collide");
    // }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            Destroy(gameObject);
        }
        if (other.gameObject.tag == "Stone")
        {
            Destroy(gameObject);
        }
    }
    
}

