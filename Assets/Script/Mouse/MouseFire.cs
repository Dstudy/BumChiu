using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseFire : MonoBehaviour
{
    public GameObject PlayerBullet;
    // Start is called before the first frame update
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(PlayerBullet, gameObject.transform.position + Vector3.up, Quaternion.identity);
            gameObject.transform.localScale = new Vector3(0.8f, 1.1f, 1);
        }

        if (Input.GetMouseButtonUp(0))
        {
            gameObject.transform.localScale = new Vector3(1f, 1f, 1);
        }
    }
}
