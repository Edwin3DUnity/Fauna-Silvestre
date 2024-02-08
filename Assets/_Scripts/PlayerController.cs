using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.Http.Headers;
using UnityEngine;
using UnityEngine.Serialization;



public class PlayerController : MonoBehaviour

{
  [SerializeField, Range(-200 , 200), Tooltip("Velocidad del personaje")] private float speed = 12;

  private float horizontal;

  [SerializeField, Range(-17, 17), Tooltip("Limite de movimiento del personaje en X")]
  private float xRange = 16;


  public GameObject food;

  private void Start()
  {
    
  }

  private void Update()
  {
    Movimiento();
    Disparar();
  }


  private void Movimiento()
  {
    horizontal = Input.GetAxis("Horizontal");
    
    transform.Translate(UnityEngine.Vector3.right * speed * Time.deltaTime * horizontal);

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
    if (Input.GetKeyDown(KeyCode.Space))
    {
      Instantiate(food, transform.position , food.transform.rotation);
    }
    
    
  }
  
}
