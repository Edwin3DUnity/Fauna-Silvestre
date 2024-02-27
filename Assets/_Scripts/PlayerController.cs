using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{


    [SerializeField, Range(0, 50), Tooltip("Velocidad de movimiento")] private float speed;

    [SerializeField, Range(-16, 16), Tooltip("Limite de moviviento en el eje X")] private float xRange = 16;

    public GameObject food;

    private float horizontal;

    private float counter = 0;
    [SerializeField, Range(1,5)] private float  nextShoot = 2;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Movimiento();

        LimiteMoveX();

        Disparar();
    }


    private void Movimiento()
    {
        horizontal = Input.GetAxis("Horizontal");

        transform.Translate(Vector3.right * speed * horizontal * Time.deltaTime);


    }



    private void LimiteMoveX()
    {
        if (transform.position.x <=  -xRange  )
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z) ;



        }
        
        if (transform.position.x >= xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }



    }


    private void Disparar()
    {
        counter += Time.deltaTime;

        Vector3 posInstanci = new Vector3(transform.position.x, transform.position.y, transform.position.z);
        Vector3 offsetY = new Vector3(0,1,0);


        if(Input.GetKeyDown(KeyCode.Space) && counter >= nextShoot )
        {
            Instantiate(food, posInstanci + offsetY, food.transform.rotation);

            counter =0;
        }



    }


}
