using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{

    public GameObject[] animals;
    private int indexAnimal;


    private float posY, posZ;

    [SerializeField, Range(-14, 14), Tooltip("Rango en el eje X")] private float xRange = 14;

    private float startDelay = 1;

    [SerializeField, Range(1, 3), Tooltip("Tiempo de espera para el siguiente disparo")] private float shootNextTime = 2;

    // Start is called before the first frame update
    void Start()
    {
        posY = transform.position.y; 
        posZ = transform.position.z;

        InvokeRepeating("GenerarAnimales()", startDelay, shootNextTime);

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void GenerarAnimales()
    {
        indexAnimal = Random.Range(0, animals.Length);

       float posRandomX = Random.Range(-xRange,xRange);

        Vector3 posIntanciar = new Vector3(posRandomX, posY,posZ);

        Instantiate(animals[indexAnimal], posIntanciar, animals[indexAnimal].transform.rotation);





    }


}
