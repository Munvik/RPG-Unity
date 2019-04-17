using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menadzer : MonoBehaviour
{
    public static Menadzer instancja; //SINGLETON
   
    public Plecak plecak;
    public GameObject PanelPlecaka;

    private void Awake()
    {
        if(instancja)
        {

            Debug.Log("Proba utworzenia drugiej instancji Menadzera !");
        }

        instancja = this;
    }

    public void Update()
    {
        ObslozPlecak();
    }

    void ObslozPlecak()
    {
        if (Input.GetKeyDown(KeyCode.B))
        {
            OtworzPlecak();
        }
    }

    void OtworzPlecak()
    {
        Time.timeScale = 0f;
        PanelPlecaka.SetActive(true);
    }


    public void WylaczObiektUI(GameObject obiekt)
    {
        obiekt.SetActive(false);
    }

    public void WlaczObiektUI(GameObject obiekt)
    {
        obiekt.SetActive(true);
    }

    public void WlozDoPlecaka(Przedmiot przedmiot)
    {
        plecak.Wloz(przedmiot);
    }

    public void Wyjdz()
    {
        Debug.Log("Wyjscie z gry");
        Application.Quit();
    }

    public void Zapisz() //TODO
    {
        Debug.Log("Zapisano gre ");
    }
}
