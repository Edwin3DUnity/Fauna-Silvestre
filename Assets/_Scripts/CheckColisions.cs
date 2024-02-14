using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckColisions : MonoBehaviour
{
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Projectile"))
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
        }

        if (other.CompareTag("Player"))
        {
            Destroy((other.gameObject));
            Destroy(gameObject);
            Time.timeScale = 0.1f;
            Debug.Log("Game Over");

        }
    }
}
