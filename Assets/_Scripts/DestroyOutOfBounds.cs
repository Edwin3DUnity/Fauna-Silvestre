using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{

    [SerializeField, Tooltip("lugar donde se eliminaran los objetos")]
    private Vector2 zRange = new Vector2(30, -10);
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > zRange.x || transform.position.z < zRange.y)
        {
            Destroy(gameObject);
        }
    }
}
