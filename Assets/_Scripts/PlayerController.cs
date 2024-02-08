using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.Serialization;



public class PlayerController : MonoBehaviour

{

    [SerializeField, Range(-10, 50), Tooltip("Velocidad de movimiento del personaje")]
    private float speed = 16;


    private float horizontal;

    [SerializeField, Range(-15, 15), Tooltip("Limite movimiento en X personaje")]
    private float xRange = 15;

    public GameObject pizza;
    [FormerlySerializedAs("posZdispararOffset")] public Vector3 posYdispararOffset;
    private void Start()
    {
        posYdispararOffset = new Vector3(transform.position.x, 1, transform.position.z);

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
            transform.position = new Vector3(- xRange, transform.position.y, transform.position.z);
        }

        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }

    }


    private void Disparar()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(pizza, transform.position + posYdispararOffset, pizza.transform.rotation);
        }
        
    }
    
}
