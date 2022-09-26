using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Clase para mover al jugador de manera horizontal
public class PlayerController : MonoBehaviour
{
    // Constante valor de entrada horizontal
    public float horizontalInput;
    // Constante valor de velociadad
    public float speed = 10.0f;
    // Contante rango que puede pasar el jugador
    public float xRange = 10.0f;
    // Objeto que servira como proyectile
    public GameObject projectilePrefab;

    void Start()
    {
        
    }

    void Update()
    {
        // Definir los rangos para que el jugador no salga de pantalla 
        // Primero para valores negativos
        if(transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }

        // Despues para valores positivos
        if(transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }

        // Toma el movimiento horizontal
        horizontalInput = Input.GetAxis("Horizontal");
        // Y nos deja mover al jugador
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);

        // Si se presiona espacio un proyectil sera lanzado
        if(Input.GetKeyDown(KeyCode.Space))
        {
            // Intancia el proyectil para lanzarlo 
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }
    }
}
