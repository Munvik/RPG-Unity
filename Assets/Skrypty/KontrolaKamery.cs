using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KontrolaKamery : MonoBehaviour
{
    public Transform gracz;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(gracz.position.x, gracz.position.y, transform.position.z);
    }
}
