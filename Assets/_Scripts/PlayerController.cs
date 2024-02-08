using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.Serialization;
using Random = UnityEngine.Random;


public class PlayerController : MonoBehaviour

{


    [SerializeField, Range(1, 20), Tooltip("velocidad de movimiento personaje")]
    private float speed = 15;

    [SerializeField, Range(-17, 17), Tooltip("Limite de movimiento en X")]
    private float xRange = 16;

    private float posY, posZ;

    public GameObject food;

    private float horizontal;

    [SerializeField, Range(0, 5), Tooltip("tiempo para inicio primer desparo")] float counter =0;

    [SerializeField, Range(0, 5), Tooltip("Tiempo para siguiente disparo")]
    private float waitNextShoot = 1;

    [SerializeField,  Tooltip("Posicion para disparar")]
    private Vector3 posYShoot = new Vector3(0 , 1.5f,0);
    private void Start()
    {
        posY = transform.position.y;
        posZ = transform.position.z;

    }


    private void Update()
    {
       MovimientoPersonaje();
       Disparar();
    }


    private void MovimientoPersonaje()
    {
        horizontal = Input.GetAxis("Horizontal");
        
        transform.Translate(Vector3.right * speed * Time.deltaTime * horizontal);

        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, posY, posZ );
        }

        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, posY, posZ);
        }

    }

    private void Disparar()
    {
        counter += Time.deltaTime;
        if (counter >= waitNextShoot)
        {
           
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Instantiate(food, transform.position + posYShoot, food.transform.rotation);
                
                
                counter = 0;
                waitNextShoot = Random.Range(0.1f,1);
            }

        }
        
        
    }
 
    
}
