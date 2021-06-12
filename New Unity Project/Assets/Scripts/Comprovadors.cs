using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Comprovadors : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject PCR;
    public GameObject scaner;
    public GameObject caducitat;
    public GameObject image;
    public GameObject treball;
    public GameObject genere;
    public GameObject avatar;
    public Texture avatarFem;
    public Texture avatarFem2;
    public Texture avatarFem3;
    public Texture avatarFem4;
    public Texture avatarFem5;
    public Texture avatarFem6;

    public Texture avatarMas;
    public Texture avatarMas2;
    public Texture avatarMas3;
    public Texture avatarMas4;
    public Texture avatarMas5;
    public Texture avatarMas6;
    public GameObject caducitatTreball;
    public GameObject DNI;
    public GameObject DNITreball;

    public Texture avatarMamutidamiesEstandar;
    public Texture avatarMamutidamiesCurt;
    public Texture avatarMamutidamiesOrelles;
    public Texture avatarMamutidamiesTrencat;

    public Texture avatarOsmiumRoig;
    public Texture avatarOsmiumGroc;
    public Texture avatarOsmiumVerd;
    public Texture avatarOsmiumMorat;

    public Texture avatarRedempcioNegre;
    public Texture avatarRedempcioRosa;
    public Texture avatarRedempcioVerd;
    public Texture avatarRedempcioRoig;
    public Texture avatarColmenaGros;
    public Texture avatarColmenaFlac;
    public Texture avatarColmenaPelut;
    public Texture avatarFungicTronc;
    public Texture avatarFungicXampi;
    public Texture avatarFungicMultiple;
    public Texture avatarVaranuVerd;
    public Texture avatarVaranuRoig;
    public Texture avatarVaranuRosa;
    public GameObject TempsScript;
    
    public AudioSource correcte;
    public AudioSource Incorrecte;
    public void OnButtonPress(){
        if (PCR.activeSelf){
            if (treball.activeSelf){
            if (comprovascaner()&&comprovacaducitat(caducitat)&&comprovagenere()&&comprovatreball()&&comprovaPCR()){
                image.GetComponent<UnityEngine.UI.Image>().color = Color.green;
                TempsScript.GetComponent<Temps>().benfets = TempsScript.GetComponent<Temps>().benfets+1;
                correcte.Play();
            }
            else{
                image.GetComponent<UnityEngine.UI.Image>().color = Color.red;
                TempsScript.GetComponent<Temps>().vides = TempsScript.GetComponent<Temps>().vides+1;
                Incorrecte.Play();
            }
            }
            else{
                if(comprovacaducitat(caducitat) && comprovagenere()&&comprovascaner()&&comprovaPCR()){
                    image.GetComponent<UnityEngine.UI.Image>().color = Color.green;
                    TempsScript.GetComponent<Temps>().benfets = TempsScript.GetComponent<Temps>().benfets+1;
                    correcte.Play();
                }
                else{
                    image.GetComponent<UnityEngine.UI.Image>().color = Color.red;
                    TempsScript.GetComponent<Temps>().vides = TempsScript.GetComponent<Temps>().vides+1;
                    Incorrecte.Play();
                }
            }
        }
        else if (Next.scaneractive == true){
            if (treball.activeSelf){
            if (comprovascaner()&&comprovacaducitat(caducitat)&&comprovagenere()&&comprovatreball()){
                image.GetComponent<UnityEngine.UI.Image>().color = Color.green;
                TempsScript.GetComponent<Temps>().benfets = TempsScript.GetComponent<Temps>().benfets+1;
                correcte.Play();
            }
            else{
                image.GetComponent<UnityEngine.UI.Image>().color = Color.red;
                TempsScript.GetComponent<Temps>().vides = TempsScript.GetComponent<Temps>().vides+1;
                Incorrecte.Play();
            }
            }
            else{
                if(comprovacaducitat(caducitat) && comprovagenere()&&comprovascaner()){
                    image.GetComponent<UnityEngine.UI.Image>().color = Color.green;
                    TempsScript.GetComponent<Temps>().benfets = TempsScript.GetComponent<Temps>().benfets+1;
                    correcte.Play();
                }
                else{
                    image.GetComponent<UnityEngine.UI.Image>().color = Color.red;
                    TempsScript.GetComponent<Temps>().vides = TempsScript.GetComponent<Temps>().vides+1;
                    Incorrecte.Play();
                }
            }
        }
        else if (treball.activeSelf){
            if (comprovacaducitat(caducitat)&&comprovagenere()&&comprovatreball()){
                image.GetComponent<UnityEngine.UI.Image>().color = Color.green;
                TempsScript.GetComponent<Temps>().benfets = TempsScript.GetComponent<Temps>().benfets+1;
                correcte.Play();
            }
            else{
                image.GetComponent<UnityEngine.UI.Image>().color = Color.red;
                TempsScript.GetComponent<Temps>().vides = TempsScript.GetComponent<Temps>().vides+1;
                Incorrecte.Play();
            }
        }
        else{
            if(comprovacaducitat(caducitat) && comprovagenere()){
                image.GetComponent<UnityEngine.UI.Image>().color = Color.green;
                TempsScript.GetComponent<Temps>().benfets = TempsScript.GetComponent<Temps>().benfets+1;
                correcte.Play();
            }
            else{
                image.GetComponent<UnityEngine.UI.Image>().color = Color.red;
                TempsScript.GetComponent<Temps>().vides = TempsScript.GetComponent<Temps>().vides+1;
                Incorrecte.Play();
            }
        }
    }
    private bool comprovacaducitat(GameObject caducitat){
        string[] dividit = caducitat.GetComponent<UnityEngine.UI.Text>().text.Split('/');
        if (int.Parse(dividit[2])<2321){
            return false;
        }else if(int.Parse(dividit[1]) == 1 && int.Parse(dividit[0]) < 30 && int.Parse(dividit[2])<=2321){
            return false;
        }else{
            return true;
        }
    }
    private bool comprovagenere(){
            string valueMasc;
            string valueFem;
            string valueCurt;
            string valueEstandar;
            string valueTrencat;
            string valueOrellut;
            string valueRoig;
            string valueRosa;
            string valueVerd;
            string valueGroc;
            string valueMorat;
            string valueNegre;
            string valueFlac;
            string valueGros;
            string valuePelut;
            string valueTronc;
            string valueMultiple;
            string valueXampi;

            Llenguatges.llenguatges.TryGetValue(Llenguatges.languge+"-Masculí",out valueMasc);
            Llenguatges.llenguatges.TryGetValue(Llenguatges.languge+"-Femení",out valueFem);
            Llenguatges.llenguatges.TryGetValue(Llenguatges.languge+"-Curta",out valueCurt);
            Llenguatges.llenguatges.TryGetValue(Llenguatges.languge+"-Estandar",out valueEstandar);
            Llenguatges.llenguatges.TryGetValue(Llenguatges.languge+"-Banya",out valueTrencat);
            Llenguatges.llenguatges.TryGetValue(Llenguatges.languge+"-Orelles",out valueOrellut);
            Llenguatges.llenguatges.TryGetValue(Llenguatges.languge+"-Roig",out valueRoig);
            Llenguatges.llenguatges.TryGetValue(Llenguatges.languge+"-Rosa",out valueRosa);
            Llenguatges.llenguatges.TryGetValue(Llenguatges.languge+"-Verd",out valueVerd);
            Llenguatges.llenguatges.TryGetValue(Llenguatges.languge+"-Groc",out valueGroc);
            Llenguatges.llenguatges.TryGetValue(Llenguatges.languge+"-Morat",out valueMorat);
            Llenguatges.llenguatges.TryGetValue(Llenguatges.languge+"-Negre",out valueNegre);
            Llenguatges.llenguatges.TryGetValue(Llenguatges.languge+"-Flac",out valueFlac);
            Llenguatges.llenguatges.TryGetValue(Llenguatges.languge+"-Gros",out valueGros);
            Llenguatges.llenguatges.TryGetValue(Llenguatges.languge+"-Pelut",out valuePelut);
            Llenguatges.llenguatges.TryGetValue(Llenguatges.languge+"-multiple",out valueMultiple);
            Llenguatges.llenguatges.TryGetValue(Llenguatges.languge+"-Tronc",out valueTronc);
            Llenguatges.llenguatges.TryGetValue(Llenguatges.languge+"-champi",out valueXampi);
            if (avatar.GetComponent<UnityEngine.UI.RawImage>().texture == avatarFem && genere.GetComponent<UnityEngine.UI.Text>().text == valueMasc || avatar.GetComponent<UnityEngine.UI.RawImage>().texture == avatarFem2 && genere.GetComponent<UnityEngine.UI.Text>().text == valueMasc || avatar.GetComponent<UnityEngine.UI.RawImage>().texture == avatarFem3 && genere.GetComponent<UnityEngine.UI.Text>().text == valueMasc || avatar.GetComponent<UnityEngine.UI.RawImage>().texture == avatarFem4 && genere.GetComponent<UnityEngine.UI.Text>().text == valueMasc || avatar.GetComponent<UnityEngine.UI.RawImage>().texture == avatarFem5 && genere.GetComponent<UnityEngine.UI.Text>().text == valueMasc || avatar.GetComponent<UnityEngine.UI.RawImage>().texture == avatarFem6 && genere.GetComponent<UnityEngine.UI.Text>().text == valueMasc){
                return false;
            }else if (avatar.GetComponent<UnityEngine.UI.RawImage>().texture == avatarMas && genere.GetComponent<UnityEngine.UI.Text>().text == valueFem || avatar.GetComponent<UnityEngine.UI.RawImage>().texture == avatarMas2 && genere.GetComponent<UnityEngine.UI.Text>().text == valueFem || avatar.GetComponent<UnityEngine.UI.RawImage>().texture == avatarMas3 && genere.GetComponent<UnityEngine.UI.Text>().text == valueFem || avatar.GetComponent<UnityEngine.UI.RawImage>().texture == avatarMas4 && genere.GetComponent<UnityEngine.UI.Text>().text == valueFem || avatar.GetComponent<UnityEngine.UI.RawImage>().texture == avatarMas5 && genere.GetComponent<UnityEngine.UI.Text>().text == valueFem || avatar.GetComponent<UnityEngine.UI.RawImage>().texture == avatarMas6 && genere.GetComponent<UnityEngine.UI.Text>().text == valueFem){
                return false;
            }
            else if (avatar.GetComponent<UnityEngine.UI.RawImage>().texture == avatarMamutidamiesCurt && genere.GetComponent<UnityEngine.UI.Text>().text != valueCurt){
                return false;
            }
            else if (avatar.GetComponent<UnityEngine.UI.RawImage>().texture == avatarMamutidamiesEstandar && genere.GetComponent<UnityEngine.UI.Text>().text != valueEstandar){
                return false;
            }
            else if (avatar.GetComponent<UnityEngine.UI.RawImage>().texture == avatarMamutidamiesTrencat && genere.GetComponent<UnityEngine.UI.Text>().text != valueTrencat){
                return false;
            }
            else if (avatar.GetComponent<UnityEngine.UI.RawImage>().texture == avatarMamutidamiesOrelles && genere.GetComponent<UnityEngine.UI.Text>().text != valueOrellut){
                return false;
            }
            else if (avatar.GetComponent<UnityEngine.UI.RawImage>().texture == avatarOsmiumRoig && genere.GetComponent<UnityEngine.UI.Text>().text != valueRoig){
                return false;
            }
            else if (avatar.GetComponent<UnityEngine.UI.RawImage>().texture == avatarOsmiumGroc && genere.GetComponent<UnityEngine.UI.Text>().text != valueGroc){
                return false;
            }
            else if (avatar.GetComponent<UnityEngine.UI.RawImage>().texture == avatarOsmiumVerd && genere.GetComponent<UnityEngine.UI.Text>().text != valueVerd){
                return false;
            }
            else if (avatar.GetComponent<UnityEngine.UI.RawImage>().texture == avatarOsmiumMorat && genere.GetComponent<UnityEngine.UI.Text>().text != valueMorat){
                return false;
            }

            else if (avatar.GetComponent<UnityEngine.UI.RawImage>().texture == avatarRedempcioNegre && genere.GetComponent<UnityEngine.UI.Text>().text != valueNegre){
                return false;
            }
            else if (avatar.GetComponent<UnityEngine.UI.RawImage>().texture == avatarRedempcioRosa && genere.GetComponent<UnityEngine.UI.Text>().text != valueRosa){
                return false;
            }
            else if (avatar.GetComponent<UnityEngine.UI.RawImage>().texture == avatarRedempcioVerd && genere.GetComponent<UnityEngine.UI.Text>().text != valueVerd){
                return false;
            }
            else if (avatar.GetComponent<UnityEngine.UI.RawImage>().texture == avatarRedempcioRoig && genere.GetComponent<UnityEngine.UI.Text>().text != valueRoig){
                return false;
            }

            else if (avatar.GetComponent<UnityEngine.UI.RawImage>().texture == avatarColmenaFlac && genere.GetComponent<UnityEngine.UI.Text>().text != valueFlac){
                return false;
            }
            else if (avatar.GetComponent<UnityEngine.UI.RawImage>().texture == avatarColmenaGros && genere.GetComponent<UnityEngine.UI.Text>().text != valueGros){
                return false;
            }
            else if (avatar.GetComponent<UnityEngine.UI.RawImage>().texture == avatarColmenaPelut && genere.GetComponent<UnityEngine.UI.Text>().text != valuePelut){
                return false;
            }

            else if (avatar.GetComponent<UnityEngine.UI.RawImage>().texture == avatarFungicMultiple && genere.GetComponent<UnityEngine.UI.Text>().text != valueMultiple){
                return false;
            }
            else if (avatar.GetComponent<UnityEngine.UI.RawImage>().texture == avatarFungicTronc && genere.GetComponent<UnityEngine.UI.Text>().text != valueTronc){
                return false;
            }
            else if (avatar.GetComponent<UnityEngine.UI.RawImage>().texture == avatarFungicXampi && genere.GetComponent<UnityEngine.UI.Text>().text != valueXampi){
                return false;
            }

            else if (avatar.GetComponent<UnityEngine.UI.RawImage>().texture == avatarVaranuRoig && genere.GetComponent<UnityEngine.UI.Text>().text != valueRoig){
                return false;
            }
            else if (avatar.GetComponent<UnityEngine.UI.RawImage>().texture == avatarVaranuRosa && genere.GetComponent<UnityEngine.UI.Text>().text != valueRosa){
                return false;
            }
            else if (avatar.GetComponent<UnityEngine.UI.RawImage>().texture == avatarVaranuVerd && genere.GetComponent<UnityEngine.UI.Text>().text != valueVerd){
                return false;
            }
            else {
                return true;
            }
    }
    private bool comprovatreball(){
        if (DNI.GetComponent<UnityEngine.UI.Text>().text != DNITreball.GetComponent<UnityEngine.UI.Text>().text){
            return false;
        }
        else if (comprovacaducitat(caducitatTreball) == false){
            return false;
        }else{
            return true;
        }
    }

    private bool comprovascaner(){
            string valueXeno;
            string valueElit;
            string valueVenga;
            string valueCodi;
            Llenguatges.llenguatges.TryGetValue(Llenguatges.languge+"-Xeno",out valueXeno);
            Llenguatges.llenguatges.TryGetValue(Llenguatges.languge+"-Elitista",out valueElit);
            Llenguatges.llenguatges.TryGetValue(Llenguatges.languge+"-Vengatiu",out valueVenga);
            Llenguatges.llenguatges.TryGetValue(Llenguatges.languge+"-Codicios",out valueCodi);
            if( scaner.GetComponent<UnityEngine.UI.Text>().text == valueXeno || scaner.GetComponent<UnityEngine.UI.Text>().text == valueElit || scaner.GetComponent<UnityEngine.UI.Text>().text == valueVenga || scaner.GetComponent<UnityEngine.UI.Text>().text == valueCodi){
                return false;
            }
            else{
                return true;
            }
    }
    private bool comprovaPCR(){
            string valueMal;
            Llenguatges.llenguatges.TryGetValue(Llenguatges.languge+"-Malalt",out valueMal);
            if(PCR.GetComponent<UnityEngine.UI.Text>().text == valueMal){
                return false;
            }
            else{
                return true;
            }
    }
    
}
