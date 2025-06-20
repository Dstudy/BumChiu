using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stone : MonoBehaviour
{
    public float speed;
    public int health;
    void Update()
    {
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
            health--;
            if (health <= 0)
            {
                Destroy(gameObject);
                health = 10;
                ScoreManager.scoreCount += 5;
            }
        }
    }
}
