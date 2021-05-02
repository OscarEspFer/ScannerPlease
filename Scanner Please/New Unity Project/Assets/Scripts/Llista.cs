using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Llista : MonoBehaviour
{
    // Start is called before the first frame update
    public static List<string> noms = new List<string>();
    public static List<string> nomsdona = new List<string>();
    public static List<string> cognoms = new List<string>();
    void Start()
    {
        addnoms();
        addcognoms();
    }
    void addnoms(){
        noms.Add("Oscar");
        noms.Add("Alex");
        noms.Add("Jose");
        noms.Add("Emiliano");
        noms.Add("Ander");
        noms.Add("Narciso");
        noms.Add("Benjamin");
        noms.Add("Noel");
        noms.Add("Francesc");
        noms.Add("Sergio");
        //female
        nomsdona.Add("Maria");
        nomsdona.Add("Mar");
        nomsdona.Add("Remedios");
        nomsdona.Add("Alba");
        nomsdona.Add("Juana");
        nomsdona.Add("Luz");
        nomsdona.Add("Virginia");
        nomsdona.Add("Rosana");
        nomsdona.Add("Rosa");
        nomsdona.Add("Carlota");
    }
    void addcognoms(){
        cognoms.Add("España");
        cognoms.Add("Ferrer");
        cognoms.Add("Franco");
        cognoms.Add("Granell");
        cognoms.Add("Fuster");
        cognoms.Add("Lopez");
        cognoms.Add("Cifuentes");
        cognoms.Add("Cano");
        cognoms.Add("Trillo");
        cognoms.Add("Arias");
        cognoms.Add("Roca");
        cognoms.Add("Matas");
        cognoms.Add("Acuña");
        cognoms.Add("Souto");
        cognoms.Add("Oliveira");
        cognoms.Add("Alarcon");
        cognoms.Add("Luque");
        cognoms.Add("Macias");
        cognoms.Add("Quevedo");
        cognoms.Add("Moran");
        cognoms.Add("Macias");
        cognoms.Add("Barros");
        cognoms.Add("Paredes");
        cognoms.Add("Belda");
    }
    public static string generatenom(){
        int value = Random.Range(0, (noms.Count));
        string nom = noms[value]+" "+generatecognom()+" "+generatecognom();
        return nom;
    }
    public static string generatenomdona(){
        int value = Random.Range(0, (nomsdona.Count));
        string nom = nomsdona[value]+" "+generatecognom()+" "+generatecognom();
        return nom;
    }
    public static string generatecognom(){
        int value = Random.Range(0, (cognoms.Count));
        string cognom = cognoms[value];
        return cognom;
    }
    public static int generatebool(){
        int value = Random.Range(0,2);
        return value;
    }
    public static string generatecaducitat(){
        int any = 2321;
        int valuedia = Random.Range(1, 32);
        int valuemes = Random.Range(1, 13);
        int valueany = Random.Range(0, 2);

        if (valueany == 0){
            valueany = Random.Range(1, 4);
            any = any - valueany;
        }else{
            valueany = Random.Range(0, 4);
            any = any + valueany;
        }
        

        return valuedia+"/"+valuemes+"/"+any;
    }
}
