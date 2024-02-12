using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EliminarObjetos : MonoBehaviour
{

    [SerializeField, Tooltip("limite en el Eje Z para eliminar Objetos")]
    private Vector2 limiteZ = new Vector2(32, -5); 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z >= limiteZ.x || transform.position.z <= limiteZ.y)
        {
            Destroy(gameObject);
        }
    }
}
