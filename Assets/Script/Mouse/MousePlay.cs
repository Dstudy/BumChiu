using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;

public class MousePlay : MonoBehaviour
{

    public float speed;
    private void Update()
    {
        #region MouseIn
        Vector3 mousepos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousepos.z = 0;

        Vector3 direction = (mousepos - gameObject.transform.position).normalized;

        gameObject.transform.position += direction * speed * Time.deltaTime;

        #endregion
        
        #region MouseLimit

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
        if(other.gameObject.tag == "EnemyShip")
            Destroy(gameObject);
    }
}
