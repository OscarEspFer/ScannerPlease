using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableLvls : MonoBehaviour
{
    // Start is called before the first frame update
    public static int nivell;
    public GameObject nivell1;
    public GameObject nivell2;
    public GameObject nivell3;
    public GameObject nivell4;
    public GameObject nivell5;
    public GameObject nivell6;
    public GameObject nivell7;
    public GameObject nivell8;
    public GameObject nivell9;
    public GameObject nivell10;
    void Start()
    {
        nivell2.GetComponent<UnityEngine.UI.Button>().interactable = false;
        nivell3.GetComponent<UnityEngine.UI.Button>().interactable = false;
        nivell4.GetComponent<UnityEngine.UI.Button>().interactable = false;
        nivell5.GetComponent<UnityEngine.UI.Button>().interactable = false;
        nivell6.GetComponent<UnityEngine.UI.Button>().interactable = false;
        nivell7.GetComponent<UnityEngine.UI.Button>().interactable = false;
        nivell8.GetComponent<UnityEngine.UI.Button>().interactable = false;
        nivell9.GetComponent<UnityEngine.UI.Button>().interactable = false;
        nivell10.GetComponent<UnityEngine.UI.Button>().interactable = false;
        if ( nivell >= 10){
            nivell10.GetComponent<UnityEngine.UI.Button>().interactable = true;
        }
        if (nivell >= 9){
            nivell9.GetComponent<UnityEngine.UI.Button>().interactable = true;
        }
        if (nivell >= 8){
            nivell8.GetComponent<UnityEngine.UI.Button>().interactable = true;
        }
        if (nivell >= 7){
            nivell7.GetComponent<UnityEngine.UI.Button>().interactable = true;
        }
        if (nivell >= 6){
            nivell6.GetComponent<UnityEngine.UI.Button>().interactable = true;
        }
        if (nivell >= 5){
            nivell5.GetComponent<UnityEngine.UI.Button>().interactable = true;
        }
        if (nivell >= 4){
            nivell4.GetComponent<UnityEngine.UI.Button>().interactable = true;
        }
        if (nivell >= 3){
            nivell3.GetComponent<UnityEngine.UI.Button>().interactable = true;
        }
        if (nivell >= 2){
            nivell2.GetComponent<UnityEngine.UI.Button>().interactable = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
