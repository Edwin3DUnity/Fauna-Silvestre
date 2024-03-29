using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;


public class PlayerController : MonoBehaviour

{

    [SerializeField, Range(-20, 200), Tooltip("velocidad de movimiento")]
    private float speed = 12;

    private float horizontal;

    [SerializeField, Range(-20, 20), Tooltip("Limite movimiento del eje X player")]
    private float xRange = 16;

    private float posY;
    private float posZ;
    private float posX;

    public GameObject pizza;

    [SerializeField, Range(0 ,5), Tooltip("Tiempo para primer disparo")]
    private float firstShoot =0;

    [SerializeField, Range(0, 5), Tooltip(" Tiempo de espera siguiente disparo")]
    private float waitNextShoot=1;
    
    
    
    private void Start()
    {
        posY = transform.position.y;
        posZ = transform.position.z;
        posX = transform.position.x;


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
        
        

        if (transform.position.x <= -xRange)
        {
            transform.position = new Vector3(-xRange, posZ,posZ);
        }

        if (transform.position.x >= xRange)
        {
            transform.position = new Vector3(xRange, posY, posZ);
        }
    }

    private void Disparar()
    {
        firstShoot += Time.deltaTime;
        Vector3 posOffsetY = new Vector3(0, 1, 0);
        if (Input.GetKeyDown(KeyCode.Space) && firstShoot >= waitNextShoot)
        {
            Instantiate(pizza, transform.position + posOffsetY, pizza.transform.rotation );
            firstShoot = 0;

        }
        
    }
}
