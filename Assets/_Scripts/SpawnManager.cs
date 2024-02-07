using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SpawnManager : MonoBehaviour
{

    public GameObject[] enemies;
    private int indexEnimies;

    [SerializeField, Range(-20, 20), Tooltip("Limite en X para generar enemigos")]
    private float spawnPosX = 20;

    private float spawnPosY;
    private float spwanPosZ;

    [SerializeField, Range(0.1f, 5), Tooltip("tiempo para generar el primer enemigo")]
    private float starDelay = 2;

    [SerializeField, Range(0.1f, 5), Tooltip(" tiempo que se demora para salir el proximo enemigo")]
    private float spawnInterval = 1.5f;
    
    // Start is called before the first frame update
    void Start()
    {
        spawnPosY = transform.position.y;
        spwanPosZ = transform.position.z;
        
        InvokeRepeating("GenerarEnemies", starDelay, spawnInterval);        

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void GenerarEnemies()
    {
        float xRandomPosition = Random.Range(-spawnPosX, spawnPosX);

        Vector3 posRandom = new Vector3(xRandomPosition,spawnPosY,spwanPosZ);

        indexEnimies = Random.Range(0, enemies.Length);

        Instantiate(enemies[indexEnimies], posRandom, enemies[indexEnimies].transform.rotation);



    }
    
}
