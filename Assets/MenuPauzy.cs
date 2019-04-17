
using UnityEngine;

public class MenuPauzy : MonoBehaviour
{
    bool pauza = false;
    public GameObject pauzaUI;

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if(pauza == true)
            {
                Kontynuuj();
            }

            else if(pauza == false)
            {
                Zapauzuj();
            }
        }
    }

    public void Kontynuuj()
    {
        pauza = false;
        Time.timeScale = 1f;
        pauzaUI.SetActive(false);
        

        Debug.Log("Gra jest kontynuowana");

    }

    public void Zapauzuj()
    {
        pauza = true;
        Time.timeScale = 0f;
        pauzaUI.SetActive(true);
        

        Debug.Log("Gra jest zapauzowana");
    }
}
