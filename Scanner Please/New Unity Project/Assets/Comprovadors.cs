using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Comprovadors : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject caducitat;
    public GameObject image;

    public GameObject genere;
    public GameObject avatar;
    public Texture avatarFem;
    public Texture avatarMas;
    public void OnButtonPress(){
        if(comprovacaducitat() && comprovagenere()){
            image.GetComponent<UnityEngine.UI.Image>().color = Color.green;
        }
        else{
            image.GetComponent<UnityEngine.UI.Image>().color = Color.red;
        }
    }
    private bool comprovacaducitat(){
        string[] dividit = caducitat.GetComponent<UnityEngine.UI.Text>().text.Split('/');
        Debug.Log(dividit[0]);
        Debug.Log(dividit[1]);
        Debug.Log(dividit[2]);
        if (int.Parse(dividit[2])<2321){
            return false;
        }else if(int.Parse(dividit[1]) == 1 && int.Parse(dividit[0]) < 30 && int.Parse(dividit[2])<=2321){
            return false;
        }else{
            return true;
        }
    }
    private bool comprovagenere(){
        if (avatar.GetComponent<UnityEngine.UI.RawImage>().texture == avatarFem && genere.GetComponent<UnityEngine.UI.Text>().text == "M"){
            return false;
        }else if (avatar.GetComponent<UnityEngine.UI.RawImage>().texture == avatarMas && genere.GetComponent<UnityEngine.UI.Text>().text == "F"){
            return false;
        }else {
            return true;
        }
    }
    
}
