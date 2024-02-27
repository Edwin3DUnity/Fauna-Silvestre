using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EliminarObjetos : MonoBehaviour
{

    [SerializeField] Vector2 limiteZ = new Vector2 (33, -8);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.z > limiteZ.x)
        {
            Destroy(gameObject);
        }    
        if(transform.position.z < limiteZ.y)
        {
            Destroy (gameObject);
            Time.timeScale = 0.5f;
        }
    }


}
