using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerController : MonoBehaviour

{

    [SerializeField, Range(-200, 200)] private float speed = 20;

    private float horizontal, vertical;
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");  
        transform.Translate(Vector3.right * Time.deltaTime * speed * horizontal);
        transform.Translate(Vector3.forward * Time.deltaTime * speed * vertical);

    }
}
