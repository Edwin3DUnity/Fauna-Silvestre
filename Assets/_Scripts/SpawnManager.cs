

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Random = UnityEngine.Random;



public class SpawnManager : MonoBehaviour
{
    public GameObject[] enemies;
    private int arrayIndex;

    public float spawnPosX = 20;
    private float spawnPosZ;

    private void Start()
    {
        spawnPosZ = transform.position.z;
    }


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            float xRange = Random.Range(-spawnPosX, spawnPosX);

            Vector3 randomPosition = new Vector3(xRange, 0, spawnPosZ);

            arrayIndex = Random.Range(0, enemies.Length);


            Instantiate(enemies[arrayIndex], randomPosition, enemies[arrayIndex].transform.rotation);






        }
    }
}
