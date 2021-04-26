using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HelikopterController : MonoBehaviour
{
    public int speed = 5;
    public Rigidbody bombaPrefab;
    int skor = 0;
    Text skorText;

    void Start()
    {
        skorText = GameObject.Find("skorText").GetComponent<Text>();
    }

    void Update()
    {
        Hareket();
        BombaAtma();
    }

    public void Hareket(){
        Vector3 Movement = new Vector3 (Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        transform.position += Movement * speed * Time.deltaTime;
    }

    public void BombaAtma(){
        if (Input.GetKeyDown(KeyCode.Space))
        {
            var bomba = Instantiate(bombaPrefab, transform.position, Quaternion.identity);
            //5 saniye sonra bomba kendini destroy ediyor
            Destroy(bomba.gameObject, 5);
        }
    }

    public void SkorArttir(){
        skor += 1;
        skorText.text = skor.ToString();
    }
}
