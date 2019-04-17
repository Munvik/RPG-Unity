
using UnityEngine;

public class PrzelacznikObiektUI : MonoBehaviour
{
    public enum Akcja { wlacz, wylacz };
    public Akcja akcja = Akcja.wlacz;
    public GameObject obiekt;



    private void OnTriggerEnter2D(Collider2D collision)
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
