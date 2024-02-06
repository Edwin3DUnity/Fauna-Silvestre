using System.Collections;
using System.Collections.Generic;


using UnityEngine;


public class PlayerController : MonoBehaviour

{

    [SerializeField, Range(-200, 200), Tooltip("Variable de velocidad del player ")]
    private float speed = 12;

    private float horizontal;

    [SerializeField, Range(-16, 16), Tooltip("Rango en posicion X de movimiento maxima del player")]
    private float xRange = 16;

    public GameObject prefabFood;
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       MovimientoPlayer();  
        DispararComida();
    }



    private void MovimientoPlayer()
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

    private void DispararComida()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(prefabFood, transform.position, prefabFood.transform.rotation);
        }
    }
}
