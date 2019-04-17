
using UnityEngine;

public class Postac : MonoBehaviour
{
    Wyposazenie wyposazenie;
    

    public int HP = 100;
    int silaAtaku = 0;

    private void Awake()
    {
        wyposazenie = GetComponent<Wyposazenie>();
    }

    void Start()
    {
        
    }


    void Update()
    {
        
    }
}
