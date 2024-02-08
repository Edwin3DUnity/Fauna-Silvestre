using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverAdelante : MonoBehaviour
{
    [SerializeField, Range(0, 20), Tooltip("velocidad de movimiento")]
    private float speed = 8;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
    
    
}
