using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vector3 = System.Numerics.Vector3;

public class MoveForward : MonoBehaviour
{

    [SerializeField, Range(-200, 200), Tooltip("Velocidad de movimiento comida")]
    private float speed =12;
    
    
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(UnityEngine.Vector3.forward * speed * Time.deltaTime);
    }
}
