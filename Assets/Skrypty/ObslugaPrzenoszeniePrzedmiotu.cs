using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ObslugaPrzenoszeniePrzedmiotu : MonoBehaviour, IDragHandler, IEndDragHandler
{
    GameObject panel;

    public void OnDrag(PointerEventData eventData)
    {
        GameObject panel = transform.Find("Panel").gameObject;

        if (panel)
        panel.transform.position = Input.mousePosition;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);

        if (hit)
            Debug.Log("You selected the " + hit.transform.name); // ensure you picked right object


        GameObject panel = transform.Find("Panel").gameObject;
        if (panel)
            panel.transform.localPosition = Vector3.zero;
    }

    // Start is called before the first frame update
    void Start()
    {
        GameObject panel = transform.Find("Panel").gameObject;

        if (!panel)
        {
            Debug.Log("Nie znaleziono panelu ");
            return;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
