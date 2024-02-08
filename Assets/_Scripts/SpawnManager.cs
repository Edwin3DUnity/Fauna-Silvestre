using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] enemies;
    private int indexEnemies;

    [SerializeField, Range(-15, 15), Tooltip("Limite para generar enemigos")]
    private float LimiteX = 14;

    private float spawnPosY;
    private float spawnPosZ;

    [SerializeField, Range(0.1f, 5), Tooltip("tiempo de espera para lanzar el primer enemigo")]
    private float starDalay = 2;


    [SerializeField, Range(0.1f, 5), Tooltip("tiempo para lanzar el proximo enemigo")]
    private float spawnInterval = 1;
    
    // Start is called before the first frame update
    void Start()
    {
        spawnPosY = transform.position.y;
        spawnPosZ = transform.position.z;
        
        
        InvokeRepeating("GenerarEnemigos", starDalay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void GenerarEnemigos()
    {
        indexEnemies = Random.Range(0, enemies.Length);
        float posRandomX = Random.Range(-LimiteX, LimiteX);

        Vector3 posSpawnEnemies = new Vector3(posRandomX,spawnPosY, spawnPosZ );

        Instantiate(enemies[indexEnemies], posSpawnEnemies, enemies[indexEnemies].transform.rotation);




    }
}
