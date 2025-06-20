using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public PlayerBullet bullet;
    public AudioSource shootSound;
    
    public void Shoot()
    {
        shootSound.Play();
        Instantiate(bullet, gameObject.transform.position, Quaternion.identity);
    }
}
