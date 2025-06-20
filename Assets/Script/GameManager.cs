using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using Unity.VisualScripting;
using UnityEngine;
using Random = UnityEngine.Random;


public class GameManager : MonoBehaviour
{
    public GameObject enemyShip;
    public float timer;
    public float time_stone;
    public GameObject stone;
    public static float screenHeight;
    public static float screenWidth;
    private void Start()
    {
        timer = 0;
        screenHeight = Camera.main.orthographicSize * 2;
        screenWidth = screenHeight * (Screen.width * 1f / Screen.height * 1f);
    }

    private void Update()
    {
        timer -= Time.deltaTime;
        time_stone -= Time.deltaTime;
        if(timer <= 0)
        {
            Vector3 positionSpawn = new Vector3();
            positionSpawn.y = 6;
            positionSpawn.x = Random.Range(-8, 8);
            Instantiate(enemyShip, positionSpawn, quaternion.identity);
            timer = 1;
        }
        if(time_stone <= 0)
        {
            Vector3 positionSpawn = new Vector3();
            positionSpawn.y = 6;
            positionSpawn.x = Random.Range(-8, 8);
            Instantiate(stone, positionSpawn, quaternion.identity);
            time_stone = 5;
        }
    }
    
}
