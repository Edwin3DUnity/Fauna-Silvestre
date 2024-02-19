using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{

    public GameObject[] enemies;
    private int indexEnemies;

    [SerializeField, Range(-14, 14), Tooltip("Limite para generar enemigos")]
    private float xRange = 14;

    private float posY;
    private float posZ;

   [SerializeField, Tooltip("Tiempo de espera para el primer enemigo")] private float firstEnemiTime = 1;

   [SerializeField, Range(1, 5), Tooltip("Tiempo de espera para el siguiente Enemy")]
   private float nextEnemy = 3; 
    
    // Start is called before the first frame update
    void Start()
    {
        posY = transform.position.y;
        posZ = transform.position.z;
        
        InvokeRepeating("GenerarEnemigos", firstEnemiTime, nextEnemy);

    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void GenerarEnemigos()
    {
        indexEnemies = Random.Range(0, enemies.Length);

        xRange = Random.Range(-14, 14);

        Vector3 posRandomSpawn = new Vector3(xRange, posY, posZ);

        Instantiate(enemies[indexEnemies], posRandomSpawn, enemies[indexEnemies].transform.rotation);

    }
    
}
