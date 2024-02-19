using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyInLimit : MonoBehaviour
{
    [SerializeField, Tooltip("Eliminar objetos en cierto limite en el eje z")]
    private Vector2 limiteZ = new Vector2(-8, 30);

    private PlayerController _playerController;
    
    // Start is called before the first frame update
    void Start()
    {
        _playerController = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z < limiteZ.x )
        {
            Destroy(gameObject);
            _playerController.GameOver = true;
            Debug.Log(" Gamer Over !!!");
            Time.timeScale = 0.2f;
        }

        if (transform.position.z > limiteZ.y)
        {
            Destroy((gameObject));
            
        }
    }
}
