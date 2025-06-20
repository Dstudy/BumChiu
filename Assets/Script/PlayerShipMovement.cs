using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShipMovement : MonoBehaviour
{
    // Start is called before the first frame update
    // Awake -> Start -> Update -> FixUpdate -> LateUpdate thuong dung lam camera

    public Transform playShipTransform;
    public float speed;
    public GameObject playerBullet;
    public float maxHealth = 100;
    private float currenHealth;
    public Healthbar healthbar;
    public AudioSource hitSound;

    Gun[] guns;
    private bool shoot;
    private void Start()
    {
        healthbar.SetMaxHealth(maxHealth);
        currenHealth = maxHealth;
        healthbar.SetHealth(currenHealth);
        guns = transform.GetComponentsInChildren<Gun>();
    }

    // Update is called once per frame
    void Update()
    {
        #region MouseInput
        Vector3 temp = new Vector3();
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            temp.x -= 1;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            temp.x += 1;
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            temp.y += 1;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            temp.y -= 1;
        }
        temp.Normalize();
        playShipTransform.position += temp * speed * Time.deltaTime;

        shoot = Input.GetKeyDown(KeyCode.Space);
        if (shoot)
        {
            shoot = false;
            foreach (Gun gun in guns)
            {
                gun.Shoot();
            }
        }

        #endregion

        #region LimitPos
        if (gameObject.transform.position.x < -GameManager.screenWidth/2)
        {
            gameObject.transform.position =
                new(-GameManager.screenWidth/2, gameObject.transform.position.y, gameObject.transform.position.z);
        }
        if (gameObject.transform.position.x > GameManager.screenWidth/2)
        {
            gameObject.transform.position =
                new(GameManager.screenWidth/2, gameObject.transform.position.y, gameObject.transform.position.z);
        }
        if (gameObject.transform.position.y > GameManager.screenHeight/2)
        {
            gameObject.transform.position =
                new(gameObject.transform.position.x, GameManager.screenHeight/2 , gameObject.transform.position.z);
        }
        if (gameObject.transform.position.y < -GameManager.screenHeight/2)
        {
            gameObject.transform.position =
                new(gameObject.transform.position.x, -GameManager.screenHeight/2 , gameObject.transform.position.z);
        }

        #endregion
        
    }

    
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "EnemyShip")
        {
            TakeDamage(5);
            hitSound.Play();
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "EnemyBullet")
        {
            TakeDamage(1);
            hitSound.Play();
        }
    }

    private void TakeDamage(int dam)
    {
        currenHealth -= dam;
        healthbar.SetHealth(currenHealth);
        if (currenHealth <= 0)
        {
            Destroy(gameObject);
            FindObjectOfType<GameOver>().EndGame();
        }
    }
    
}
