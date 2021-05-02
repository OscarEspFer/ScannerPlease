using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComprovadorsDenied : MonoBehaviour
{
    public GameObject caducitat;
    public GameObject image;
    public void OnButtonPress(){
        if(comprovacaducitat()){
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
        if (int.Parse(dividit[2])>2321){
            return false;
        }else if(int.Parse(dividit[1]) > 1 && int.Parse(dividit[2])==2321){
            return false;
        }else if(int.Parse(dividit[1]) == 1 && int.Parse(dividit[2])==2321 && int.Parse(dividit[0])>=30){
            return false;
        }else{
            return true;
        }
    }
}
