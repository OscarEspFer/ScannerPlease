using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Progress : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject P1;
    public GameObject P2;
    public GameObject P3;
    public GameObject P4;
    public GameObject P5;
    public GameObject P6;
    public GameObject P7;
    public GameObject P8;
    public GameObject P9;
    public GameObject P10;
    public GameObject E1;
    public GameObject E2;
    public GameObject E3;
    public GameObject TempsScript;
    void Start()
    {
        P1.SetActive(false);
        P2.SetActive(false);
        P3.SetActive(false);
        P4.SetActive(false);
        P5.SetActive(false);
        P6.SetActive(false);
        P7.SetActive(false);
        P8.SetActive(false);
        P9.SetActive(false);
        P10.SetActive(false);

        E1.SetActive(false);
        E2.SetActive(false);
        E3.SetActive(false);
    }

    // Update is called once per frame
    public void Activar(){
        
        switch (TempsScript.GetComponent<Temps>().benfets){
            case 1: P1.SetActive(true); break;
            case 2: P2.SetActive(true); break;
            case 3: P3.SetActive(true); break;
            case 4: P4.SetActive(true); break;
            case 5: P5.SetActive(true); break;
            case 6: P6.SetActive(true); break;
            case 7: P7.SetActive(true); break;
            case 8: P8.SetActive(true); break;
            case 9: P9.SetActive(true); break;
            case 10: P10.SetActive(true); break;
        }
        switch (TempsScript.GetComponent<Temps>().vides){
            case 1: E1.SetActive(true); break;
            case 2: E2.SetActive(true); break;
            case 3: E3.SetActive(true); break;
        }
    }
}
