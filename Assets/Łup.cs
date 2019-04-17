using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Łup : MonoBehaviour
{
    public List<Przedmiot> przedmioty;
    public GameObject podpowiedz;
    public Menadzer menadzer;
    public Plecak plecak;
    bool zebrany = false;
    bool Bpodpowiedz = false;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(zabracLoot()) //nacisnieto E przy loocie
        {
            zbierzLoot();
        }
    }

    bool zabracLoot()
    {
        return (Bpodpowiedz == true && Input.GetKey(KeyCode.E) && !zebrany);
    }

    void zbierzLoot()
    {
        
        for (int i = 0; i < przedmioty.Count; i++)
        {
            plecak.Wloz(przedmioty[i]);
        
        }

        //przedmioty.Clear();

        Debug.Log("Zebrano przedmioty");
        zebrany = true;
        transform.GetComponent<BoxCollider2D>().enabled = false;

        for(int i=0; i<transform.childCount; i++)
        {
            transform.GetChild(i).gameObject.SetActive(false);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            if(!zebrany)
            {
                podpowiedz.SetActive(true);
                Bpodpowiedz = true;
            }

        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            {
                podpowiedz.SetActive(false);
                Bpodpowiedz = false;
            }
        }
    }   
}
