using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Next : MonoBehaviour
{
    public GameObject nom;
    public GameObject procedencia;
    public GameObject genere;
    public GameObject caducitat;
    public GameObject DNI;
    public GameObject image;
    public GameObject avatar;
    public GameObject buttonpass;
    public GameObject buttondenied;
    public Texture AvatarFem;
    public Texture AvatarMas;
    // Start is called before the first frame update
    void Start()
    {
        this.OnButtonPress();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnButtonPress(){
        StartCoroutine(esperador());
        
    }
    IEnumerator esperador(){
        buttonpass.GetComponent<UnityEngine.UI.Button>().interactable = false;
        buttondenied.GetComponent<UnityEngine.UI.Button>().interactable = false;
        yield return new WaitForSecondsRealtime(2);
        image.GetComponent<UnityEngine.UI.Image>().color = Color.white;
        int sexe = Llista.generatebool();
        string noms;
        if (sexe == 0){
            noms = Llista.generatenom();
            genere.GetComponent<UnityEngine.UI.Text>().text = "M";
            if (Random.Range(0,8) > 1){
                avatar.GetComponent<UnityEngine.UI.RawImage>().texture = AvatarMas;
            }else{
                avatar.GetComponent<UnityEngine.UI.RawImage>().texture = AvatarFem;
            }
        }
        else{
            noms = Llista.generatenomdona();
            genere.GetComponent<UnityEngine.UI.Text>().text = "F";
            if (Random.Range(0,8) > 1){
                avatar.GetComponent<UnityEngine.UI.RawImage>().texture = AvatarFem;
            }else{
                avatar.GetComponent<UnityEngine.UI.RawImage>().texture = AvatarMas;
            }
        }
        nom.GetComponent<UnityEngine.UI.Text>().text = noms;
        procedencia.GetComponent<UnityEngine.UI.Text>().text = "text";
        caducitat.GetComponent<UnityEngine.UI.Text>().text = Llista.generatecaducitat();
        DNI.GetComponent<UnityEngine.UI.Text>().text = "text";
        buttondenied.GetComponent<UnityEngine.UI.Button>().interactable = true;
        buttonpass.GetComponent<UnityEngine.UI.Button>().interactable = true;
    }
}
