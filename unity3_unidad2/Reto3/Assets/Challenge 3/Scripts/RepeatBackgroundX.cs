using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatBackgroundX : MonoBehaviour
{
    private Vector3 startPos;
    private float repeatWidth;

    private void Start()
    {
        startPos = transform.position; // Estable la posicion default de inicio
        repeatWidth = GetComponent<BoxCollider>().size.x / 2; // Marca la repeticion del ancho de la mitad del fondo
    }

    private void Update()
    {
        // If background moves left by its repeat width, move it back to start position
        // Si el fondo se mueve a la izquierda se repita, de regraeso a la posicion de inicio
        if (transform.position.x < startPos.x - repeatWidth)
        {
            transform.position = startPos;
        }
    }

 
}


