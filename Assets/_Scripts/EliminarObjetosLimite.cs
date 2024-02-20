using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EliminarObjetosLimite : MonoBehaviour
{

    [SerializeField, Tooltip("Limite en Z para eliminar Objetos")]
    private Vector2 limiteZ = new Vector2(31, -10);

    private PlayerController _playerController;
    
    // Start is called before the first frame update
    void Start()
    {
        _playerController = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {

        if (transform.position.z > limiteZ.x)
        {
            Destroy(gameObject);
        }

        if (transform.position.z < limiteZ.y)
        {
            Destroy(gameObject);
            _playerController.GameOver = true;
            Debug.Log("Game Over !!!");
            Time.timeScale = 0.05f;

        }
    }
}
