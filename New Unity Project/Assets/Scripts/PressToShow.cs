using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PressToShow : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject llista;
    public GameObject canvas;
    public Text text;
    public Text text2;
    public Text textos;
    public void OnButtonPress(){
        Text textbox = Instantiate(textos) as Text;
        textbox.transform.SetParent(canvas.transform, false);
        //textos.transform.parent = canvas.transform;
        int sexe = Llista.generatebool();
        string nom;
        if (sexe == 0){
            nom = Llista.generatenom();
        }
        else{
            nom = Llista.generatenomdona();
        }
        text.text = nom;
        if (Llista.generatebool() == 0){
            text2.text = nom;
        }
        else{
            if (sexe == 0){
            nom = Llista.generatenom();
            }
            else{
            nom = Llista.generatenomdona();
            }
            text2.text = nom;
        }
    }
    /* string generatenom(){
        int value = Random.Range(0, (Llista.noms.Count-1));
        string nom = Llista.noms[value]+" "+generatecognom()+" "+generatecognom();
        return nom;
    }
    string generatenomdona(){
        int value = Random.Range(0, (Llista.nomsdona.Count-1));
        string nom = Llista.nomsdona[value]+" "+generatecognom()+" "+generatecognom();
        return nom;
    }
    string generatecognom(){
        int value = Random.Range(0, (Llista.cognoms.Count-1));
        string cognom = Llista.cognoms[value];
        return cognom;
    } */
}
