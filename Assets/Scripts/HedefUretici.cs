using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HedefUretici : MonoBehaviour
{
    public GameObject bombaPrefab;
    float timer = 0f;

    void Start()
    {
        
    }

    void Update()
    {
        if(timer <= 0.5f){
            timer += Time.deltaTime;
        } else {
            timer = 0;
            HedefUret();
        }
    }

    public void HedefUret(){
        int randomNumber = Random.Range(0, 10);  
        var bomba = Instantiate(bombaPrefab, new Vector3(randomNumber, 0.0f, 0.0f), Quaternion.identity, transform);
        bomba.transform.parent = null;
    }
}