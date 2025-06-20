using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoDestroy : MonoBehaviour
{
    // Start is called before the first frame update
    public float timeToDie;
    private void Start()
    {
        Destroy(gameObject,timeToDie);
    }

    // Update is called once per frame
    
}
