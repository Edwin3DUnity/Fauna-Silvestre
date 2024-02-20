using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{


    public GameObject[] animals;
    private int indexAnimals;

    [SerializeField, Range(-15, 15), Tooltip("Rango en eje X para spawnear animales")]
    private float xRange =14;

    private float posYSpawn;
    private float posZSpawn;


    private float animalsFirtsTime = 1;

    [SerializeField, Range(0.1f, 2), Tooltip("Tiempo para spawnear el siguiente animal")] private float
    animalsNextSpawn = 2;
    // Start is called before the first frame update
    void Start()
    {
        posYSpawn = transform.position.y;
        posZSpawn = transform.position.z;
        
        
        InvokeRepeating("GenerarAnimales", animalsFirtsTime, animalsNextSpawn);
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void GenerarAnimales()
    {
        float xPosRandom = Random.Range(-xRange, xRange);
        
        Vector3 posSpawnAnimals = new Vector3(xPosRandom, posYSpawn, posZSpawn);
        
        indexAnimals = Random.Range(0, animals.Length);

      

   

        Instantiate(animals[indexAnimals], posSpawnAnimals, animals[indexAnimals].transform.rotation);





    }
}
