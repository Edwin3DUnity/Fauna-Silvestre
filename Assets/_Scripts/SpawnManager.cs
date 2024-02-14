using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] enemies;
    private int indexEnemies;

    [SerializeField, Range(-14, 14), Tooltip(" limite en el Eje X para spawnear enemigos")]
    private float xRange;

    private float posY;
    private float posZ;

    [SerializeField] private float startDelay = 1;

    [SerializeField] private float timeNextSpawn = 2;
    // Start is called before the first frame update
    void Start()
    {
        posY = transform.position.y;
        posZ = transform.position.z;
        
        InvokeRepeating("GenerarEnemies", startDelay, timeNextSpawn);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void GenerarEnemies()
    {
        indexEnemies = Random.Range(0, enemies.Length);
        float xRandomPos = Random.Range(-14, 14);

        Vector3 randomPos = new Vector3(xRandomPos, posY, posZ);

        Instantiate(enemies[indexEnemies], randomPos, enemies[indexEnemies].transform.rotation);




    }

}
