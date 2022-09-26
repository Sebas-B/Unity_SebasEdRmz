using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayerX : MonoBehaviour
{
    public GameObject plane;
    private Vector3 offset = new Vector3(-23,3,3);

    void Start()
    {

    }

    void Update()
    {
        transform.position = plane.transform.position + offset;
    }
}
