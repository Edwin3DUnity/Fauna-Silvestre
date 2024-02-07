using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EliminarObjetos : MonoBehaviour
{

    [SerializeField, Tooltip("Limite para eliminar Objto")]
    private Vector2 limite = new Vector2(30, -15);
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > limite.x || transform.position.z < limite.y)
        {
            Destroy(gameObject);
        }
        
        
        
    }
}
