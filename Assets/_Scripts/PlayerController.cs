using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using Vector3 = System.Numerics.Vector3;

public class PlayerController : MonoBehaviour

{
    [SerializeField, Range(-200, 200), Tooltip("Velocidad de player")]
    private float speed = 12;

    private float horizontal, vertical;

    [SerializeField, Range(-17, 17), Tooltip("Limite movimiento en X del player")]
    private float xRrange;


    public GameObject projectilePrefab;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");
        
        
      transform.Translate(UnityEngine.Vector3.right * speed * Time.deltaTime * horizontal );
     // transform.Translate(UnityEngine.Vector3.forward * speed * Time.deltaTime * vertical);


      if (transform.position.x < -xRrange)
      {
          transform.position = new UnityEngine.Vector3(-xRrange, transform.position.y, transform.position.z);
          
      }

      if (transform.position.x > xRrange)
      {
          transform.position = new UnityEngine.Vector3(xRrange, transform.position.y, transform.position.z);
      }
      
    }
    
    
    
    
}
