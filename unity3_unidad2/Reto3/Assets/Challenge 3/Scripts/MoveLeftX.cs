using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeftX : MonoBehaviour
{
    public float speed;
    private PlayerControllerX playerControllerScript;
    private float leftBound = -10;

    void Start()
    {
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerControllerX>();
    }

    void Update()
    {
        // Si el juego no ha terminado se movera a la izquerda 
        if (!playerControllerScript.gameOver)
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime, Space.World);
        }

        // Si el objeto sale fuera de la pantalla y no es el fondo, se destruye
        if (transform.position.x < leftBound && !gameObject.CompareTag("Background"))
        {
            Destroy(gameObject);
        }

    }
}
