using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KontrolaKolideraKamery : MonoBehaviour
{
    KontrolaKamery kamera;
    // Start is called before the first frame update
    void Start()
    {
        kamera = Camera.main.GetComponent<KontrolaKamery>();

        if(!kamera)
        {
            Debug.Log("Nie udalo sie zlokalizowac kamera.KontrolKamery !");
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        kamera.coll = true;
    }


    private void OnCollisionExit2D(Collision2D collision)
    {
        kamera.coll = false;
    }
    // Update is called once per frame
    void Update()
    {
       transform.position = kamera.gracz.position;
    }

}
