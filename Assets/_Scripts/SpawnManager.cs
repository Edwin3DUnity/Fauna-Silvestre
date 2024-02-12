using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] enemies;
    private int indexEnemies;


    [SerializeField, Range(-15, 15), Tooltip("limite en x para spawnear los enemigos")]
    private float xRange = 14;

    private float posY;

    private float posZ;

    [SerializeField, Range(0, 05f), Tooltip("Tiempo inicial para generar enemigos")]
    private float stardaley =0;

    [SerializeField, Range(0, 5f), Tooltip("Tiempo de espera para proximo spawneo de enemigos")]
    private float waitNextSpawn ;
    
    
    // Start is called before the first frame update
    void Start()
    {
       posY = transform.position.y;
       posZ = transform.position.z;
        InvokeRepeating("GenerarEnemigos", stardaley, waitNextSpawn);
       

    }

    // Update is called once per frame
    void Update()
    {
        
        stardaley += Time.deltaTime;
    }

    private void GenerarEnemigos()
    {
        

         
        
         if(stardaley >= waitNextSpawn)
         {
             waitNextSpawn = Random.Range(0, 5);
             float xPosRandom = Random.Range(-xRange, xRange);

             Vector3 posRandom = new Vector3(xPosRandom, posY, posZ);

             indexEnemies = Random.Range(0, enemies.Length);

             Instantiate(enemies[indexEnemies], posRandom, enemies[indexEnemies].transform.rotation);
             stardaley = 0;
         } 
        
       
        



    }
    
}
