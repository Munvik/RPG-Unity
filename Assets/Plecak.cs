using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plecak : MonoBehaviour
{


    public List<Przedmiot> przedmioty;
    public ObslugaPlecaka obslugaPlecaka;
    public float maxUdzwig = 30f;
    float udzwig = 10f;
    int miejsce = 10;

    public void Wloz(Przedmiot przedmiot)
    {
        if(przedmioty.Count >= miejsce)
        {
            Debug.Log("Za malo miejsca w plecaku !");
        }

        else if(udzwig + przedmiot.waga > maxUdzwig)
        {
            Debug.Log("Za duzy ciezar !");
        }

        else
        {
            Debug.Log("Wlozono przedmiot");
            obslugaPlecaka.Wloz(przedmiot);
            przedmioty.Add(przedmiot);
            udzwig += przedmiot.waga;
            
        }
        
    }

  

    private void Update()
    {
        
    }
}
