using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    [SerializeField, Range(0, 50), Tooltip("Velocidad de movimiento en X")]
    private float speed = 9;

    private float horizontal;

    [SerializeField, Range(-16, 16), Tooltip("Limite de movimiento en el eje X")]
    private float xRange = 16;



    public GameObject food;

    private Vector3 posShoot;
   [SerializeField] private Vector3 offsetY;

  [SerializeField] private float startDalay = 0;

   [SerializeField, Range(1, 3), Tooltip("tiempo de espeara para el siguiente disparo")]
   private float waitNextShoot = 2;


   private bool gameOver;

   public bool GameOver
   {
       get => gameOver;
       set => gameOver = value;
   }
   
    // Start is called before the first frame update
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
        MovimientoP();
        Disparar();
    }

    private void MovimientoP()
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
        posShoot = new Vector3(transform.position.x, transform.position.y, transform.position.z);
        offsetY = new Vector3(0, 1.5f, 0);
        startDalay += Time.deltaTime;
        if (Input.GetKeyDown(KeyCode.Space)  && startDalay >= waitNextShoot )
        {
            Instantiate(food, posShoot + offsetY, food.transform.rotation);
            startDalay = 0;
        }
        
    }
    
}
