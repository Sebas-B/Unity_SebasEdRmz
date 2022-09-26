using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float velocidad;
    void Start()
    {
        
    }

    void Update()
    {
        float avanza = Input.GetAxis("Vertical");
        float girar = Input.GetAxis("Horizontal");
        
        transform.Translate(Vector3.forward*Time.deltaTime*velocidad*avanza);
        transform.Rotate(Vector3.up, Time.deltaTime * 30*girar);
    }
}
