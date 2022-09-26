using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamaraController : MonoBehaviour
{
    public GameObject maquinaMisterio;
    private Vector3 pos = new Vector3(0,5,-10);

    void Start()
    {
        
    }

    void Update()
    {
        transform.position = maquinaMisterio.transform.position + pos;
    }
}
