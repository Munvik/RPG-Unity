using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chuśtanie : MonoBehaviour
{
    public float czasWSekundach;
    public float kat;
    float czas;
    // Start is called before the first frame update
    void Start()
    {
        czas = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        czas += Time.deltaTime;

        transform.localRotation = Quaternion.Euler(new Vector3(transform.rotation.x, transform.rotation.y, Mathf.Sin((czas/czasWSekundach)*2) * kat));
    }
}
