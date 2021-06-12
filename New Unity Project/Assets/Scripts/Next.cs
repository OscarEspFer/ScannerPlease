using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Next : MonoBehaviour
{
    private string noms="";

    public GameObject salut;

    public int lvl;
    public static bool scaneractive = false;
    public GameObject ferramentes;
    public GameObject scaner;
    public GameObject nom;
    public GameObject genere;
    public GameObject caducitat;
    public GameObject DNI;
    public GameObject image;
    public GameObject avatar;
    public GameObject buttonpass;
    public GameObject buttondenied;
    public Canvas treball;
    public GameObject DNItreball;
    public GameObject professiotreball;
    public GameObject caducitattreball;
    public Texture AvatarFem;
    public Texture AvatarFem2;
    public Texture AvatarFem3;
    public Texture AvatarFem4;
    public Texture AvatarFem5;
    public Texture AvatarFem6;

    public Texture AvatarMas;
    public Texture AvatarMas2;
    public Texture AvatarMas3;
    public Texture AvatarMas4;
    public Texture AvatarMas5;
    public Texture AvatarMas6;
    public Texture AvatarMamutidamiesStandar;
    public Texture AvatarMamutidamiesTrencat;
    public Texture AvatarMamutidamiesCurt;
    public Texture AvatarMamutidamiesOrelles;

    public Texture AvatarOsmiumRoig;
    public Texture AvatarOsmiumGroc;
    public Texture AvatarOsmiumVerd;
    public Texture AvatarOsmiumMorat;

    public Texture AvatarRedempcioNegre;
    public Texture AvatarRedempcioRosa;
    public Texture AvatarRedempcioVerd;
    public Texture AvatarRedempcioRoig;

    public Texture AvatarColmenaFlac;
    public Texture AvatarColmenaGros;
    public Texture AvatarColmenaPelut;

    public Texture AvatarFungicTronc;
    public Texture AvatarFungicXampi;
    public Texture AvatarFungicMultiple;
    public Texture AvatarVaranuRoig;
    public Texture AvatarVaranuRosa;
    public Texture AvatarVaranuVerd;
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
        string value;
        yield return new WaitForSecondsRealtime(1);
        image.GetComponent<UnityEngine.UI.Image>().color = Color.white;
        int numeroespecies;
        if (lvl > 7){
            numeroespecies = 7;
        }
        else{
            numeroespecies = lvl;
        }
        int especie = Random.Range(1,numeroespecies);
        
        switch (especie){

            case 1: {
                int sexe = Llista.generatebool();
                if (sexe == 0){
                    noms = Llista.generatenom();
                    Llenguatges.llenguatges.TryGetValue(Llenguatges.languge+"-Masculí",out value);
                    genere.GetComponent<UnityEngine.UI.Text>().text = value;
                    if (Random.Range(0,8) > 1){
                        switch (Random.Range(0,5)){
                            case 0: avatar.GetComponent<UnityEngine.UI.RawImage>().texture = AvatarMas;
                                    break;
                            case 1: avatar.GetComponent<UnityEngine.UI.RawImage>().texture = AvatarMas2;
                                    break;
                            case 2: avatar.GetComponent<UnityEngine.UI.RawImage>().texture = AvatarMas3;
                                    break;
                            case 3: avatar.GetComponent<UnityEngine.UI.RawImage>().texture = AvatarMas4;
                                    break;
                            case 4: avatar.GetComponent<UnityEngine.UI.RawImage>().texture = AvatarMas5;
                                    break;
                            case 5: avatar.GetComponent<UnityEngine.UI.RawImage>().texture = AvatarMas6;
                                    break;
                            default: avatar.GetComponent<UnityEngine.UI.RawImage>().texture = AvatarMas;
                                    break;
                        }
                        
                    }else{
                        switch (Random.Range(0,5)){
                            case 0: avatar.GetComponent<UnityEngine.UI.RawImage>().texture = AvatarFem;
                                    break;
                            case 1: avatar.GetComponent<UnityEngine.UI.RawImage>().texture = AvatarFem2;
                                    break;
                            case 2: avatar.GetComponent<UnityEngine.UI.RawImage>().texture = AvatarFem3;
                                    break;
                            case 3: avatar.GetComponent<UnityEngine.UI.RawImage>().texture = AvatarFem4;
                                    break;
                            case 4: avatar.GetComponent<UnityEngine.UI.RawImage>().texture = AvatarFem5;
                                    break;
                            case 5: avatar.GetComponent<UnityEngine.UI.RawImage>().texture = AvatarFem6;
                                    break;
                            default: avatar.GetComponent<UnityEngine.UI.RawImage>().texture = AvatarFem;
                                    break;
                        }
                    }
                }
                else{
                    noms = Llista.generatenomdona();
                    Llenguatges.llenguatges.TryGetValue(Llenguatges.languge+"-Femení",out value);
                    genere.GetComponent<UnityEngine.UI.Text>().text = value;
                    if (Random.Range(0,8) > 1){
                        switch (Random.Range(0,5)){
                            case 0: avatar.GetComponent<UnityEngine.UI.RawImage>().texture = AvatarFem;
                                    break;
                            case 1: avatar.GetComponent<UnityEngine.UI.RawImage>().texture = AvatarFem2;
                                    break;
                            case 2: avatar.GetComponent<UnityEngine.UI.RawImage>().texture = AvatarFem3;
                                    break;
                            case 3: avatar.GetComponent<UnityEngine.UI.RawImage>().texture = AvatarFem4;
                                    break;
                            case 4: avatar.GetComponent<UnityEngine.UI.RawImage>().texture = AvatarFem5;
                                    break;
                            case 5: avatar.GetComponent<UnityEngine.UI.RawImage>().texture = AvatarFem6;
                                    break;
                            default: avatar.GetComponent<UnityEngine.UI.RawImage>().texture = AvatarFem;
                                    break;
                        }
                    }else{
                        switch (Random.Range(0,5)){
                            case 0: avatar.GetComponent<UnityEngine.UI.RawImage>().texture = AvatarMas;
                                    break;
                            case 1: avatar.GetComponent<UnityEngine.UI.RawImage>().texture = AvatarMas2;
                                    break;
                            case 2: avatar.GetComponent<UnityEngine.UI.RawImage>().texture = AvatarMas3;
                                    break;
                            case 3: avatar.GetComponent<UnityEngine.UI.RawImage>().texture = AvatarMas4;
                                    break;
                            case 4: avatar.GetComponent<UnityEngine.UI.RawImage>().texture = AvatarMas5;
                                    break;
                            case 5: avatar.GetComponent<UnityEngine.UI.RawImage>().texture = AvatarMas6;
                                    break;
                            default: avatar.GetComponent<UnityEngine.UI.RawImage>().texture = AvatarMas;
                                    break;
                        }
                    }
                }
            }
            break;
            case 2:{
                int sexe = Random.Range(1,4);
                noms = Llista.generatenommamutidamies();
                switch (sexe){
                    case 1: {
                        Llenguatges.llenguatges.TryGetValue(Llenguatges.languge+"-Estandar",out value);
                        genere.GetComponent<UnityEngine.UI.Text>().text = value;
                        if (Random.Range(0,8) > 1){
                            avatar.GetComponent<UnityEngine.UI.RawImage>().texture = AvatarMamutidamiesStandar;
                        }else{
                            avatar.GetComponent<UnityEngine.UI.RawImage>().texture = AvatarMamutidamiesTrencat;
                        }
                    }
                    break;
                    case 2: {
                        Llenguatges.llenguatges.TryGetValue(Llenguatges.languge+"-Banya",out value);
                        genere.GetComponent<UnityEngine.UI.Text>().text = value;
                        if (Random.Range(0,8) > 1){
                            avatar.GetComponent<UnityEngine.UI.RawImage>().texture = AvatarMamutidamiesTrencat;
                        }else{
                            avatar.GetComponent<UnityEngine.UI.RawImage>().texture = AvatarMamutidamiesStandar;
                        }
                    }
                    break;
                    case 3:{
                        Llenguatges.llenguatges.TryGetValue(Llenguatges.languge+"-Curta",out value);
                        genere.GetComponent<UnityEngine.UI.Text>().text = value;
                        if (Random.Range(0,8) > 1){
                            avatar.GetComponent<UnityEngine.UI.RawImage>().texture = AvatarMamutidamiesCurt;
                        }else{
                            avatar.GetComponent<UnityEngine.UI.RawImage>().texture = AvatarMamutidamiesOrelles;
                        }
                    } break;
                    case 4:{
                        Llenguatges.llenguatges.TryGetValue(Llenguatges.languge+"-Orelles",out value);
                        genere.GetComponent<UnityEngine.UI.Text>().text = value;
                        if (Random.Range(0,8) > 1){
                            avatar.GetComponent<UnityEngine.UI.RawImage>().texture = AvatarMamutidamiesOrelles;
                        }else{
                            avatar.GetComponent<UnityEngine.UI.RawImage>().texture = AvatarMamutidamiesCurt;
                        }
                    } break;
                    default:{
                        Llenguatges.llenguatges.TryGetValue(Llenguatges.languge+"-Orelles",out value);
                        genere.GetComponent<UnityEngine.UI.Text>().text = value;
                        if (Random.Range(0,8) > 1){
                            avatar.GetComponent<UnityEngine.UI.RawImage>().texture = AvatarMamutidamiesOrelles;
                        }else{
                            avatar.GetComponent<UnityEngine.UI.RawImage>().texture = AvatarMamutidamiesCurt;
                        }
                        break;
                    }
                }
            }
            break;
            case 3:{
                int sexe = Random.Range(1,4);
                noms = Llista.generatenomosmium();
                switch (sexe){
                    case 0:
                    case 1: {
                        Llenguatges.llenguatges.TryGetValue(Llenguatges.languge+"-Roig",out value);
                        genere.GetComponent<UnityEngine.UI.Text>().text = value;
                        if (Random.Range(0,8) > 1){
                            avatar.GetComponent<UnityEngine.UI.RawImage>().texture = AvatarOsmiumRoig;
                        }else{
                            avatar.GetComponent<UnityEngine.UI.RawImage>().texture = AvatarOsmiumGroc;
                        }
                    }
                    break;
                    case 2: {
                        Llenguatges.llenguatges.TryGetValue(Llenguatges.languge+"-Groc",out value);
                        genere.GetComponent<UnityEngine.UI.Text>().text = value;
                        if (Random.Range(0,8) > 1){
                            avatar.GetComponent<UnityEngine.UI.RawImage>().texture = AvatarOsmiumGroc;
                        }else{
                            avatar.GetComponent<UnityEngine.UI.RawImage>().texture = AvatarOsmiumVerd;
                        }
                    }
                    break;
                    case 3:{
                        Llenguatges.llenguatges.TryGetValue(Llenguatges.languge+"-Verd",out value);
                        genere.GetComponent<UnityEngine.UI.Text>().text = value;
                        if (Random.Range(0,8) > 1){
                            avatar.GetComponent<UnityEngine.UI.RawImage>().texture = AvatarOsmiumVerd;
                        }else{
                            avatar.GetComponent<UnityEngine.UI.RawImage>().texture = AvatarOsmiumRoig;
                        }
                    } break;
                    case 4:{
                        Llenguatges.llenguatges.TryGetValue(Llenguatges.languge+"-Morat",out value);
                        genere.GetComponent<UnityEngine.UI.Text>().text = value;
                        if (Random.Range(0,8) > 1){
                            avatar.GetComponent<UnityEngine.UI.RawImage>().texture = AvatarOsmiumMorat;
                        }else{
                            avatar.GetComponent<UnityEngine.UI.RawImage>().texture = AvatarOsmiumRoig;
                        }
                    } break;
                    default:{
                        Llenguatges.llenguatges.TryGetValue(Llenguatges.languge+"-Morat",out value);
                        genere.GetComponent<UnityEngine.UI.Text>().text = value;
                        if (Random.Range(0,8) > 1){
                            avatar.GetComponent<UnityEngine.UI.RawImage>().texture = AvatarOsmiumMorat;
                        }else{
                            avatar.GetComponent<UnityEngine.UI.RawImage>().texture = AvatarOsmiumRoig;
                        }
                        break;
                    }
                }
            }
            break;
            case 4:{
                int sexe = Random.Range(1,4);
                noms = Llista.generatenomoredempcio();
                switch (sexe){
                    case 0:
                    case 1: {
                        Llenguatges.llenguatges.TryGetValue(Llenguatges.languge+"-Roig",out value);
                        genere.GetComponent<UnityEngine.UI.Text>().text = value;
                        if (Random.Range(0,8) > 1){
                            avatar.GetComponent<UnityEngine.UI.RawImage>().texture = AvatarRedempcioRoig;
                        }else{
                            avatar.GetComponent<UnityEngine.UI.RawImage>().texture = AvatarRedempcioNegre;
                        }
                    }
                    break;
                    case 2: {
                        Llenguatges.llenguatges.TryGetValue(Llenguatges.languge+"-Negre",out value);
                        genere.GetComponent<UnityEngine.UI.Text>().text = value;
                        if (Random.Range(0,8) > 1){
                            avatar.GetComponent<UnityEngine.UI.RawImage>().texture = AvatarRedempcioNegre;
                        }else{
                            avatar.GetComponent<UnityEngine.UI.RawImage>().texture = AvatarRedempcioRoig;
                        }
                    }
                    break;
                    case 3:{
                        Llenguatges.llenguatges.TryGetValue(Llenguatges.languge+"-Verd",out value);
                        genere.GetComponent<UnityEngine.UI.Text>().text = value;
                        if (Random.Range(0,8) > 1){
                            avatar.GetComponent<UnityEngine.UI.RawImage>().texture = AvatarRedempcioVerd;
                        }else{
                            avatar.GetComponent<UnityEngine.UI.RawImage>().texture = AvatarRedempcioRosa;
                        }
                    } break;
                    case 4:{
                        Llenguatges.llenguatges.TryGetValue(Llenguatges.languge+"-Rosa",out value);
                        genere.GetComponent<UnityEngine.UI.Text>().text = value;
                        if (Random.Range(0,8) > 1){
                            avatar.GetComponent<UnityEngine.UI.RawImage>().texture = AvatarRedempcioRosa;
                        }else{
                            avatar.GetComponent<UnityEngine.UI.RawImage>().texture = AvatarRedempcioVerd;
                        }
                    } break;
                    default:{
                        Llenguatges.llenguatges.TryGetValue(Llenguatges.languge+"-Rosa",out value);
                        genere.GetComponent<UnityEngine.UI.Text>().text = value;
                        if (Random.Range(0,8) > 1){
                            avatar.GetComponent<UnityEngine.UI.RawImage>().texture = AvatarRedempcioRosa;
                        }else{
                            avatar.GetComponent<UnityEngine.UI.RawImage>().texture = AvatarRedempcioVerd;
                        }
                        break;
                    }
                }
            }break;
            case 5:{
                int sexe = Random.Range(1,3);
                noms = Llista.generatenomocolmena();
                switch (sexe){
                    case 0:
                    case 1: {
                        Llenguatges.llenguatges.TryGetValue(Llenguatges.languge+"-Flac",out value);
                        genere.GetComponent<UnityEngine.UI.Text>().text = value;
                        if (Random.Range(0,8) > 1){
                            avatar.GetComponent<UnityEngine.UI.RawImage>().texture = AvatarColmenaFlac;
                        }else{
                            avatar.GetComponent<UnityEngine.UI.RawImage>().texture = AvatarColmenaPelut;
                        }
                    }
                    break;
                    case 2: {
                        Llenguatges.llenguatges.TryGetValue(Llenguatges.languge+"-Gros",out value);
                        genere.GetComponent<UnityEngine.UI.Text>().text = value;
                        if (Random.Range(0,8) > 1){
                            avatar.GetComponent<UnityEngine.UI.RawImage>().texture = AvatarColmenaGros;
                        }else{
                            avatar.GetComponent<UnityEngine.UI.RawImage>().texture = AvatarColmenaFlac;
                        }
                    }
                    break;
                    case 3:{
                        Llenguatges.llenguatges.TryGetValue(Llenguatges.languge+"-Pelut",out value);
                        genere.GetComponent<UnityEngine.UI.Text>().text = value;
                        if (Random.Range(0,8) > 1){
                            avatar.GetComponent<UnityEngine.UI.RawImage>().texture = AvatarColmenaPelut;
                        }else{
                            avatar.GetComponent<UnityEngine.UI.RawImage>().texture = AvatarColmenaGros;
                        }
                    } break;
                    default:{
                        Llenguatges.llenguatges.TryGetValue(Llenguatges.languge+"-Pelut",out value);
                        genere.GetComponent<UnityEngine.UI.Text>().text = value;
                        if (Random.Range(0,8) > 1){
                            avatar.GetComponent<UnityEngine.UI.RawImage>().texture = AvatarColmenaPelut;
                        }else{
                            avatar.GetComponent<UnityEngine.UI.RawImage>().texture = AvatarColmenaGros;
                        }
                        break;
                    }
                }
            }break;
            case 6:{
                int sexe = Random.Range(1,3);
                noms = Llista.generatenomofungic();
                switch (sexe){
                    case 0:
                    case 1: {
                        Llenguatges.llenguatges.TryGetValue(Llenguatges.languge+"-Tronc",out value);
                        genere.GetComponent<UnityEngine.UI.Text>().text = value;
                        if (Random.Range(0,8) > 1){
                            avatar.GetComponent<UnityEngine.UI.RawImage>().texture = AvatarFungicTronc;
                        }else{
                            avatar.GetComponent<UnityEngine.UI.RawImage>().texture = AvatarFungicMultiple;
                        }
                    }
                    break;
                    case 2: {
                        Llenguatges.llenguatges.TryGetValue(Llenguatges.languge+"-champi",out value);
                        genere.GetComponent<UnityEngine.UI.Text>().text = value;
                        if (Random.Range(0,8) > 1){
                            avatar.GetComponent<UnityEngine.UI.RawImage>().texture = AvatarFungicXampi;
                        }else{
                            avatar.GetComponent<UnityEngine.UI.RawImage>().texture = AvatarFungicTronc;
                        }
                    }
                    break;
                    case 3:{
                        Llenguatges.llenguatges.TryGetValue(Llenguatges.languge+"-multiple",out value);
                        genere.GetComponent<UnityEngine.UI.Text>().text = value;
                        if (Random.Range(0,8) > 1){
                            avatar.GetComponent<UnityEngine.UI.RawImage>().texture = AvatarFungicMultiple;
                        }else{
                            avatar.GetComponent<UnityEngine.UI.RawImage>().texture = AvatarFungicXampi;
                        }
                    } break;
                    default:{
                        Llenguatges.llenguatges.TryGetValue(Llenguatges.languge+"-multiple",out value);
                        genere.GetComponent<UnityEngine.UI.Text>().text = value;
                        if (Random.Range(0,8) > 1){
                            avatar.GetComponent<UnityEngine.UI.RawImage>().texture = AvatarFungicMultiple;
                        }else{
                            avatar.GetComponent<UnityEngine.UI.RawImage>().texture = AvatarFungicXampi;
                        }
                        break;
                    }
                }
            }break;
            case 7:{
                int sexe = Random.Range(1,3);
                noms = Llista.generatenomovaranu();
                switch (sexe){
                    case 0:
                    case 1: {
                        Llenguatges.llenguatges.TryGetValue(Llenguatges.languge+"-Rosa",out value);
                        genere.GetComponent<UnityEngine.UI.Text>().text = value;
                        if (Random.Range(0,8) > 1){
                            avatar.GetComponent<UnityEngine.UI.RawImage>().texture = AvatarVaranuRosa;
                        }else{
                            avatar.GetComponent<UnityEngine.UI.RawImage>().texture = AvatarVaranuVerd;
                        }
                    }
                    break;
                    case 2: {
                        Llenguatges.llenguatges.TryGetValue(Llenguatges.languge+"-Roig",out value);
                        genere.GetComponent<UnityEngine.UI.Text>().text = value;
                        if (Random.Range(0,8) > 1){
                            avatar.GetComponent<UnityEngine.UI.RawImage>().texture = AvatarVaranuRoig;
                        }else{
                            avatar.GetComponent<UnityEngine.UI.RawImage>().texture = AvatarVaranuRosa;
                        }
                    }
                    break;
                    case 3:{
                        Llenguatges.llenguatges.TryGetValue(Llenguatges.languge+"-Verd",out value);
                        genere.GetComponent<UnityEngine.UI.Text>().text = value;
                        if (Random.Range(0,8) > 1){
                            avatar.GetComponent<UnityEngine.UI.RawImage>().texture = AvatarVaranuVerd;
                        }else{
                            avatar.GetComponent<UnityEngine.UI.RawImage>().texture = AvatarVaranuRoig;
                        }
                    } break;
                    default:{
                        Llenguatges.llenguatges.TryGetValue(Llenguatges.languge+"-Verd",out value);
                        genere.GetComponent<UnityEngine.UI.Text>().text = value;
                        if (Random.Range(0,8) > 1){
                            avatar.GetComponent<UnityEngine.UI.RawImage>().texture = AvatarVaranuVerd;
                        }else{
                            avatar.GetComponent<UnityEngine.UI.RawImage>().texture = AvatarVaranuRoig;
                        }
                        break;
                    }
                }
            }break;
            default:{
                int sexe = Llista.generatebool();
                if (sexe == 0){
                    noms = Llista.generatenom();
                    Llenguatges.llenguatges.TryGetValue(Llenguatges.languge+"-Masculí",out value);
                    genere.GetComponent<UnityEngine.UI.Text>().text = value;
                    if (Random.Range(0,8) > 1){
                        avatar.GetComponent<UnityEngine.UI.RawImage>().texture = AvatarMas;
                    }else{
                        avatar.GetComponent<UnityEngine.UI.RawImage>().texture = AvatarFem;
                    }
                }
                else{
                    noms = Llista.generatenomdona();
                    Llenguatges.llenguatges.TryGetValue(Llenguatges.languge+"-Femení",out value);
                    genere.GetComponent<UnityEngine.UI.Text>().text = value;
                    if (Random.Range(0,8) > 1){
                        avatar.GetComponent<UnityEngine.UI.RawImage>().texture = AvatarFem;
                    }else{
                        avatar.GetComponent<UnityEngine.UI.RawImage>().texture = AvatarMas;
                    }
                }
                break;
            }
        }
        DNI.GetComponent<UnityEngine.UI.Text>().text = Llista.generateDNI();
        int documents = Random.Range(1,3);
        if (lvl >= 4){
            switch(documents){
                case 1: treball.gameObject.SetActive(false); break;
                case 2: treball.gameObject.SetActive(true);
                        if(Random.Range(1,10)<=2){
                            DNItreball.GetComponent<UnityEngine.UI.Text>().text = Llista.generateDNI(DNI.GetComponent<UnityEngine.UI.Text>().text);
                        }
                        else{
                            DNItreball.GetComponent<UnityEngine.UI.Text>().text = DNI.GetComponent<UnityEngine.UI.Text>().text;
                        }
                        professiotreball.GetComponent<UnityEngine.UI.Text>().text = Llista.generateprofessio(Llenguatges.languge);
                        caducitattreball.GetComponent<UnityEngine.UI.Text>().text = Llista.generatecaducitat();
                        break;

                default: treball.gameObject.SetActive(false);
                        break;
            }
        }
        else{
            treball.gameObject.SetActive(false);
        }
        if (lvl >= 6){
            scaner.GetComponent<UnityEngine.UI.Text>().text = Llista.generatescaner(Llenguatges.languge);
            scaneractive = true;
        }
        else{
            ferramentes.gameObject.SetActive(false);
        }
        if (lvl >= 8){
            int salutvalue = Random.Range(1,10);
            if (salutvalue <= 2){
                Llenguatges.llenguatges.TryGetValue(Llenguatges.languge+"-Malalt",out value);
                salut.GetComponent<UnityEngine.UI.Text>().text = value;
            }
            else{
                Llenguatges.llenguatges.TryGetValue(Llenguatges.languge+"-Saludable",out value);
                salut.GetComponent<UnityEngine.UI.Text>().text = value;
            }
        }
        salut.gameObject.SetActive(false);
        scaner.gameObject.SetActive(false);
        nom.GetComponent<UnityEngine.UI.Text>().text = noms;
        caducitat.GetComponent<UnityEngine.UI.Text>().text = Llista.generatecaducitat();
        
        
        buttondenied.GetComponent<UnityEngine.UI.Button>().interactable = true;
        buttonpass.GetComponent<UnityEngine.UI.Button>().interactable = true;
    }
}
