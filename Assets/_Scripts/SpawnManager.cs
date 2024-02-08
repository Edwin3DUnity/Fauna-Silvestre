using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{

    public GameObject[] enemies;
    private int indexEnemies;


    [SerializeField, Range(-18, 18), Tooltip("Rango para generar enemigos en posicion x")]
    private float xRange = 15;

    private float posY;
    private float posZ;

    [SerializeField, Range(0, 3), Tooltip("Tiempo inicial para primer enemigo generado")]
    private float stardalay = 1;

    [SerializeField, Range(1, 4), Tooltip("Tiempo para generar el próximo enemigo")]
    private float waitNextEnemy =2;
    
    
    // Start is called before the first frame update
    void Start()
    {
        posY = transform.position.y;
        posZ = transform.position.z;
        waitNextEnemy = Random.Range(2, 4);
        InvokeRepeating("GenerarEnemies", stardalay, waitNextEnemy);

    }

    // Update is called once per frame
    void Update()
    {
        Debug.LogFormat("tiempo de spawn enemigo " + waitNextEnemy );
    }

    private void GenerarEnemies()
    {
        float randomXPos = Random.Range(-xRange, xRange);

        Vector3 posRandomEnemies = new Vector3(randomXPos, posY, posZ);


        indexEnemies = Random.Range(0, enemies.Length);
        
        Instantiate(enemies[indexEnemies], posRandomEnemies, enemies[indexEnemies].transform.rotation);



    }
    
    
}
