using System.Collections;
using System.Collections.Generic;


using UnityEngine;
using Vector3 = System.Numerics.Vector3;


public class PlayerController : MonoBehaviour

{

    [SerializeField, Range(-200, 200), Tooltip("Velocidad de movimiento personaje")]
    private float speed = 12;


    private float horizontal;

    [SerializeField, Range(-20, 20), Tooltip("limite de movimiento persenaje horizontal")]
    private float xRange = 16;


    public GameObject prefabsComida;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
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
            transform.position = new UnityEngine.Vector3(-xRange, transform.position.y, transform.position.z);
        }

        if (transform.position.x > xRange)
        {
            transform.position = new UnityEngine.Vector3(xRange, transform.position.y, transform.position.z);
        }

    }

    private void Disparar()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(prefabsComida, transform.position, prefabsComida.transform.rotation);
        }
    }
    
}
