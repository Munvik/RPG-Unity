using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrzelacznikObiektUIKlawiszem : PrzelacznikObiektUI
{
    public KeyCode klawisz;
   // bool isOn = false;

    //private void OnTriggerEnter2D(Collider2D collision)
    //{
    //    isOn = true;

        
    //}

    //private void OnTriggerExit2D(Collider2D collision)
    //{
    //    isOn = false;
    //}

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (Input.GetKey(klawisz))
        {
            if (akcja == Akcja.wlacz)
                Menadzer.instancja.WlaczObiektUI(obiekt);

            else if (akcja == Akcja.wylacz)
            {
                Menadzer.instancja.WylaczObiektUI(obiekt);
                Debug.Log("Obiekt wylaczany");
            }
        }
    }

    //private void Update()
    //{
    //    if (Input.GetKey(klawisz) && isOn)
    //    {
    //        if (akcja == Akcja.wlacz)
    //            Menadzer.instancja.WlaczObiektUI(obiekt);

    //        else if (akcja == Akcja.wylacz)
    //        {
    //            Menadzer.instancja.WylaczObiektUI(obiekt);
    //            Debug.Log("Obiekt wylaczany");
    //        }
    //    }
    //}
}
