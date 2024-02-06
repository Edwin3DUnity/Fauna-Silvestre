using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EliminarObjetos : MonoBehaviour
{

    [SerializeField, Tooltip("Lugar para eliminar objetos")]
    private Vector2 rangoELiminar = new Vector2(30, -10);
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > rangoELiminar.x || transform.position.z < rangoELiminar.y)
        {
            Destroy(gameObject);
        }
    }
}
