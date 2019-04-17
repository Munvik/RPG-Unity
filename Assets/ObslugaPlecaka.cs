
using UnityEngine;

public class ObslugaPlecaka : MonoBehaviour
{
    public GameObject plecak;
    public BP_Slot[] sloty;
    int iloscPrzedmiotow = 0;

    private void Awake()
    {
        //sloty = plecak.transform.GetComponentsInChildren<BP_Slot>();

        //for (int i = 0; i < sloty.Length; i++)
        //{
        //    sloty[i].gameObject.SetActive(false);
        //}

        //Debug.Log("Ilosc slotow = " + sloty.Length);
    }
    // Start is called before the first frame update
    void Start()
    {
        

        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.B))
        {
            Time.timeScale = 1f;
            gameObject.SetActive(false);
        }


    }

    public void Wloz(Przedmiot przedmiot)
    {
        sloty = plecak.transform.GetComponentsInChildren<BP_Slot>();

        if(iloscPrzedmiotow < sloty.Length)
        {
            
            Debug.Log("nazwa przedmiotu = " + sloty[iloscPrzedmiotow].gameObject.name);
            BP_Slot slot = sloty[iloscPrzedmiotow];
           
            slot.gameObject.SetActive(true);
            slot.przedmiot = przedmiot;
            slot.ikona.sprite = slot.przedmiot.ikona;
            

            iloscPrzedmiotow++;
        }


        Debug.Log("sloty.length = " + sloty.Length);
     
        
        
    }
}
