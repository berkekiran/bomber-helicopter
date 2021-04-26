using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HedefController : MonoBehaviour
{
    public int speed = 2;

    void Start()
    {
        
    }

    void Update()
    {
        transform.position += transform.forward * speed * Time.deltaTime;
    }
}
