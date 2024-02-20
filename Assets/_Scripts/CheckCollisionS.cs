using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckCollisionS : MonoBehaviour
{

    private PlayerController _playerController;
    // Start is called before the first frame update
    void Start()
    {
        _playerController = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Destroy(gameObject);
            Destroy(other.gameObject);
            _playerController.GameOver = true;
            Debug.Log("GameOver!!!");
            Time.timeScale = 0.05F;

        }

        if (other.CompareTag("Projectile"))
        {
            Destroy(gameObject);
            Destroy(other.gameObject);
        }
        
        
    }
}
