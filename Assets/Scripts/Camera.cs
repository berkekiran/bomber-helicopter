using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    Vector3 position;
    Transform helikopterTransform { get { return FindObjectOfType<HelikopterController>().transform; } }

    void Start()
    {
        position = helikopterTransform.position - transform.position;
    }

    void Update()
    {
        transform.position = helikopterTransform.position - position;
    }
}
