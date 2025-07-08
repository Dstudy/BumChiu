using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public AudioSource shootSound;
    
    public void Shoot()
    {
        shootSound.Play();
        GameObject bullet = ObjectPooling.Instance.GetPooledObject();
        Debug.Log(bullet);
        if (bullet != null)
        {
            bullet.transform.position = gameObject.transform.position;
            bullet.gameObject.SetActive(true);
        }    
    }
}
