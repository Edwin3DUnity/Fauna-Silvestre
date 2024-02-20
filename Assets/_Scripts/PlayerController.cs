using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class PlayerController : MonoBehaviour
{

    [FormerlySerializedAs("Speed")] [SerializeField, Range(0,50), Tooltip("Velocidad de movimiento del personaje")] private float speed = 8;

    private float horizontal;
    private float posY;
    private float posZ;

    [SerializeField, Range(-17, 16), Tooltip("Limite de movimiento del personaje en el eje X")]
   private float xRange = 16;


   [SerializeField]   private GameObject food;

   [SerializeField, Range(0, 3), Tooltip("Tiempo para primer shoot")]
   private float firstShootTime;

   [SerializeField, Range(1, 3), Tooltip("Tiempo de espera para el siguiente disparo")]
   private float nextShoot = 1;
    
    // Start is called before the first frame update
    void Start()
    {
        posY = transform.position.y;
        posZ = transform.position.z;

       
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

        if (transform.position.x < -xRange )
        {
            transform.position = new Vector3(-xRange, posY, posZ);
            
        }

        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, posY, posZ);
        }
    }

    private void Disparar()
    {

        firstShootTime += Time.deltaTime;
        Vector3 posSpawn = new Vector3(transform.position.x, posY, posZ);

        Vector3 offsetY = new Vector3(0, 1, 0);
        
        if (Input.GetKeyDown(KeyCode.Space) && firstShootTime >= nextShoot)
        {
            Instantiate(food, posSpawn + offsetY, food.transform.rotation);
            firstShootTime = 0;
        }
        
    }
    
}
