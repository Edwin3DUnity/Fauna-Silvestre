using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EliminarObjetos : MonoBehaviour
{
    [SerializeField, Tooltip("limite para eliminar enemigos en el eje Y")] private Vector2  limiteY= new Vector2(30, -15);
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > limiteY.x)
        {
            Destroy(gameObject);
        }

        if (transform.position.z < limiteY.y)
        {
            Destroy(gameObject);
            Time.timeScale = 0.2f;
            
        }
    }
}
