using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KontrolaKamery : MonoBehaviour
{
    public Transform gracz;
    GameObject kolider;

    [SerializeField]
    float minX;
    [SerializeField]
    float maxX;

    [SerializeField]
    float minY;
    [SerializeField]
    float maxY;
    //coll - zmienna do obsługi kamery, aby kamera nie wyszla poza mape.
    //obsluguje ja skrypt KontrolaKolideraKamery.
    public bool coll = true;
    const float kameraOffset = 5f;
  
    void Start()
    {
        kolider = gameObject.transform.Find("KamKolider").gameObject;

        if (kolider)
        {
            Camera camera = GetComponent<Camera>();
            float height = camera.orthographicSize * 2f;
            float width = height * camera.aspect;

            kolider.transform.localScale = new Vector3(width, height, kolider.transform.localScale.z);
        }

        else
        {
            Debug.Log("Nie znaleziono KamKolider !");
        }
    }


    // Update is called once per frame
    void Update()
    {

        transform.position = new Vector3(Mathf.Clamp(gracz.position.x, minX, maxX), Mathf.Clamp(gracz.position.y, minY, maxY), transform.position.z);

        

    }
}
