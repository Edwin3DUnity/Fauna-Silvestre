using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LimiteDestruccion : MonoBehaviour
{
    [SerializeField, Tooltip("Limite de destruccion de objetos en el eje z")]
    private Vector2 limiteZ = new Vector2(32,-10);
    
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > limiteZ.x )
        {
            Destroy(gameObject);
        }

        if (transform.position.z < limiteZ.y)
        {
            Destroy((gameObject));
            Time.timeScale = 0.1F;
            Debug.Log("Game Over");
        }
        
        
    }
}
