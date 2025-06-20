using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShip : MonoBehaviour
{
    public float speed;
    public float fireRate;
    private float fireTime;
    public GameObject EnemyBullet;
    public AudioSource boomSound;
    void Update()
    {
        fireTime -= Time.deltaTime;
        if (fireTime < 0)
        {
            Instantiate(EnemyBullet, gameObject.transform.position + Vector3.down, Quaternion.identity);
            fireTime = fireRate;
        }
        
        
        
        gameObject.transform.position += Vector3.down * speed * Time.deltaTime;
    }
    // private void OnTriggerEnter2D(Collider2D other)
    // {
    //     Destroy(gameObject);
    //     // Debug.Log("Collide");
    // }
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "PlayerBullet")
        {
            boomSound.Play();
            Destroy(gameObject);
            ScoreManager.scoreCount += 1;
        }
    }

}
