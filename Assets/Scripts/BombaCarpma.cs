using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombaCarpma : MonoBehaviour
{
    HelikopterController helikopterController { get { return FindObjectOfType<HelikopterController>(); } }
    bool bombaCarptiMi = false;

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.tag == "HedefTag" && !bombaCarptiMi){
            helikopterController.SkorArttir();
            bombaCarptiMi = true;
            Destroy(collision. collider. gameObject);
            Destroy(gameObject);
        }
    }
}
