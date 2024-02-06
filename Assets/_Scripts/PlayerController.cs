using System.Collections;
using System.Collections.Generic;


using UnityEngine;


public class PlayerController : MonoBehaviour

{


    [SerializeField, Range(-200, 200), Tooltip("Velocidad de movimiento personaje")]
    private float speed;

    
    
    private float horizontal;

    [SerializeField, Range(-22, 22), Tooltip("Lugar de movimiento personaje limite")]
    private float xRange =16;

    public GameObject prefabdisparar;
    
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

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(prefabdisparar, transform.position, prefabdisparar.transform.rotation);
        }
        
        
    }
}
