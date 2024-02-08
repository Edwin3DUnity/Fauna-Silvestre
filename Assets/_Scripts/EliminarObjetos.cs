using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EliminarObjetos : MonoBehaviour
{

    [SerializeField, Tooltip("Limite para eliminar objetos en pantalla")]
    private Vector2 limiteZ = new Vector2(30, -10);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > limiteZ.x)
        {
            Destroy(gameObject);
        }

        if (transform.position.z < limiteZ.y)
        {
            Destroy(gameObject);

            Time.timeScale = 0.2f;
            Debug.Log("Game Over =(=)(=)!!!!");
            SceneManager.LoadScene(0);


        }
        
        
    }
}
