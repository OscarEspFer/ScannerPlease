using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class showhide : MonoBehaviour
{

    public Canvas passport;
    public Canvas treball;
    public Canvas scaner;
    public Canvas salut;

    public bool PCR;
    private bool apretat = false;
    // Start is called before the first frame update
    void Start()
    {
        scaner.GetComponent<Canvas>().enabled = false;
        salut.GetComponent<Canvas>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void OnButtonPress(){
        if (apretat == false){
            showscanner();
            hidepassport();
            hidetreball();
            if (PCR == true){
                showsalut();
            }
            apretat = true;
        }else{
            hidescanner();
            hidesalut();
            showpassport();
            showtreball();
            apretat = false;
        }
    }

    void showpassport(){
        passport.GetComponent<Canvas>().enabled = true;
    }
    void showtreball(){
        treball.GetComponent<Canvas>().enabled = true;
    }
    void showscanner(){
        scaner.GetComponent<Canvas>().enabled = true;
    }
    void showsalut(){
        salut.GetComponent<Canvas>().enabled = true;
    }
    void hidepassport(){
        passport.GetComponent<Canvas>().enabled = false;
    }
    void hidetreball(){
        treball.GetComponent<Canvas>().enabled = false;
    }
    void hidescanner(){
        scaner.GetComponent<Canvas>().enabled = false;
    }
    void hidesalut(){
        salut.GetComponent<Canvas>().enabled = false;
    }
}
