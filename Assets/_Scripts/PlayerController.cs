using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerController : MonoBehaviour
{


    [SerializeField, Range(0, 20), Tooltip("Velocidad de movimiento")]
    private float speed = 9;

    private float horizontal;

    [SerializeField, Range(-17, 17), Tooltip(" Limite movimiento en el eje X")]
    private float xRange = 16;
    
    
    
    
    public GameObject pizza;

   [SerializeField] private float firstShoot = 0;
    [SerializeField, Range(1,2), Tooltip(" tiempo de espera para el siguiente disparo")] private float waitNextShoot = 1;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
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
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }

        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }


    }


    private void Disparar()
    {
        firstShoot += Time.deltaTime;
        Vector3 shootPos = new Vector3(transform.position.x, transform.position.y, transform.position.z);
        Vector3 offsetY = new Vector3(0, 1, 0);
             
             
        if (Input.GetKeyDown(KeyCode.Space) && firstShoot >= waitNextShoot)
        {
            Instantiate(pizza, shootPos + offsetY, pizza.transform.rotation);

            firstShoot = 0;
        }
    }
}
