using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class PlayerBullet : MonoBehaviour
{
    public float speed;
    void Update()
    {
        gameObject.transform.position += Vector3.up* Time.deltaTime * speed;
    }
    

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "EnemyShip" || collision.gameObject.tag == "Stone" || collision.gameObject.tag == "Barrier")
        {
            gameObject.SetActive(false);
        }
    }
}

