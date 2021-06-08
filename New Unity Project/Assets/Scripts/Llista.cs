using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Llista : MonoBehaviour
{
    // Start is called before the first frame update
    public static List<string> professions = new List<string>();
    public static List<string> professionsESP = new List<string>();
    public static List<string> professionsENG = new List<string>();
    public static List<string> professionsROM = new List<string>();
    public static List<string> professionsUKR = new List<string>();
    public static List<string> professionsRUS = new List<string>();
    public static List<string> noms = new List<string>();
    public static List<string> nomsdona = new List<string>();
    public static List<string> nomsmamutidamies = new List<string>();
    public static List<string> nomsvaranu = new List<string>();
    public static List<string> cognomsvaranu = new List<string>();
    public static List<string> nomsosmium = new List<string>();
    public static List<string> cognomsosmium = new List<string>();
    public static List<string> nomsredempcio = new List<string>();
    public static List<string> cognomsredempcio = new List<string>();
    public static List<string> nomscolmena = new List<string>();
    public static List<string> cognomscolmena = new List<string>();
    public static List<string> nomsfungic = new List<string>();
    public static List<string> cognomsfungic = new List<string>();
    public static List<string> cognoms = new List<string>();
    public static List<string> scaner = new List<string>();
    public static List<string> scanerESP = new List<string>();
    public static List<string> scanerENG = new List<string>();
    public static List<string> scanerROM = new List<string>();
    public static List<string> scanerUKR = new List<string>();
    public static List<string> scanerRUS = new List<string>();
    void Start()
    {
        addnoms();
        addcognoms();
        addprofessions();
        addscaners();
    }
    void addnoms(){
        //16
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
        noms.Add("Manel");
        noms.Add("Simó");
        noms.Add("Carles");
        noms.Add("Xavi");
        noms.Add("David");
        noms.Add("Roldolfo");
        //female16
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
        nomsdona.Add("Verónica");
        nomsdona.Add("Amelia");
        nomsdona.Add("Andrea");
        nomsdona.Add("Cristina");
        nomsdona.Add("Anabel");
        nomsdona.Add("Concepción");

        nomsmamutidamies.Add("Buu");
        nomsmamutidamies.Add("Buub");
        nomsmamutidamies.Add("Buuz");
        nomsmamutidamies.Add("Buud");
        nomsmamutidamies.Add("Munut");
        nomsmamutidamies.Add("Nuut");
        nomsmamutidamies.Add("Lutu");
        nomsmamutidamies.Add("Summ");
        nomsmamutidamies.Add("Tuluv");
        nomsmamutidamies.Add("Lumu");
        nomsmamutidamies.Add("Yumu");
        nomsmamutidamies.Add("Xugu");
        nomsmamutidamies.Add("Pum");
        nomsmamutidamies.Add("Muf");
        nomsmamutidamies.Add("Furum");
        nomsmamutidamies.Add("Rum");
        nomsmamutidamies.Add("Suruc");
        nomsmamutidamies.Add("Rupufu");
        nomsmamutidamies.Add("Pud");
        nomsmamutidamies.Add("Dudu");
        nomsmamutidamies.Add("Uu");
        nomsmamutidamies.Add("Nunu");
        nomsmamutidamies.Add("Nuu");
        nomsmamutidamies.Add("Nuc");
        nomsmamutidamies.Add("Nuk");
        nomsmamutidamies.Add("Curu");
        nomsmamutidamies.Add("Sulup");
        nomsmamutidamies.Add("Purr");
        nomsmamutidamies.Add("Zuu");
        nomsmamutidamies.Add("Ustu");
        nomsmamutidamies.Add("Gup");

        nomsosmium.Add("Cigonyal");
        nomsosmium.Add("Eix");
        nomsosmium.Add("Motor");
        nomsosmium.Add("Leves");
        nomsosmium.Add("Biela");
        nomsosmium.Add("Pistó");
        nomsosmium.Add("Anell");
        nomsosmium.Add("Cargol");
        nomsosmium.Add("Rosca");
        nomsosmium.Add("Arandela");
        nomsosmium.Add("Clau");
        nomsosmium.Add("Perns");
        nomsosmium.Add("Rebló");
        nomsosmium.Add("Passadora");
        nomsosmium.Add("Dobladora");
        nomsosmium.Add("Frontissa");
        nomsosmium.Add("Pestell");
        nomsosmium.Add("Palanca");
        nomsosmium.Add("Moll");
        nomsosmium.Add("Rodament");
        nomsosmium.Add("Embragatge");
        nomsosmium.Add("Fre");
        nomsosmium.Add("Xip");
        nomsosmium.Add("Suspensió");
        nomsosmium.Add("Amortiguador");
        nomsosmium.Add("Interruptor");
        nomsosmium.Add("Tecla");
        nomsosmium.Add("Bateria");
        nomsosmium.Add("Engranatge");
        nomsosmium.Add("Turbina");
        nomsosmium.Add("Condensador");
        nomsosmium.Add("Diodo");

        nomsvaranu.Add("Ak'taar");
        nomsvaranu.Add("A'krok");
        nomsvaranu.Add("Bi'ku'tor");
        nomsvaranu.Add("Brok'ta");
        nomsvaranu.Add("Krok'o'dile");
        nomsvaranu.Add("Drk'o");
        nomsvaranu.Add("Es'ku'o");
        nomsvaranu.Add("Frs");
        nomsvaranu.Add("Gris'kal");
        nomsvaranu.Add("Ik'tribal");
        nomsvaranu.Add("L'ks");
        nomsvaranu.Add("Mon'ka");
        nomsvaranu.Add("Ns'ta");
        nomsvaranu.Add("Ors");
        nomsvaranu.Add("Puk'tuk");
        nomsvaranu.Add("Trr'Turr");
        nomsvaranu.Add("Rr'varr");
        nomsvaranu.Add("Ser'pi'st");
        nomsvaranu.Add("Urr'k");
        nomsvaranu.Add("Var'num");
        nomsvaranu.Add("Xosxas");
        nomsvaranu.Add("Yka'ir");
        nomsvaranu.Add("Zas'tak");
        nomsvaranu.Add("Kar'ka'sa");
        nomsvaranu.Add("Klos'ka");
        nomsvaranu.Add("Es'ka'ta'ka");
        nomsvaranu.Add("Sarpa");
        nomsvaranu.Add("Dak'tor");
        nomsvaranu.Add("Rok'tar");
        nomsvaranu.Add("Drak'o");
        nomsvaranu.Add("Sal'mander");
        nomsvaranu.Add("Tar'tl");

        nomsredempcio.Add("Ki");
        nomsredempcio.Add("Ri");
        nomsredempcio.Add("Ko");
        nomsredempcio.Add("Ro");
        nomsredempcio.Add("Xiu");
        nomsredempcio.Add("Qe");
        nomsredempcio.Add("Quaq");
        nomsredempcio.Add("Kulu");
        nomsredempcio.Add("Ku");
        nomsredempcio.Add("Rru");
        nomsredempcio.Add("Prru");
        nomsredempcio.Add("Na");
        nomsredempcio.Add("Güo");
        nomsredempcio.Add("Piu");
        nomsredempcio.Add("Ti");
        nomsredempcio.Add("Tik");
        nomsredempcio.Add("Fi");
        nomsredempcio.Add("Fu");
        nomsredempcio.Add("Qui");
        nomsredempcio.Add("Pie");

        nomscolmena.Add("Recolector");
        nomscolmena.Add("Buscador");
        nomscolmena.Add("Caçador");
        nomscolmena.Add("Cuidador");
        nomscolmena.Add("Constructor");
        nomscolmena.Add("Estercoler");
        nomscolmena.Add("Obrer");
        nomscolmena.Add("Soldat");
        nomscolmena.Add("Emisor");
        nomscolmena.Add("Explorador");

        nomsfungic.Add("Agaricus");
        nomsfungic.Add("Bisporus");
        nomsfungic.Add("Sanguifluus");
        nomsfungic.Add("Himenio");
        nomsfungic.Add("Espora");
        nomsfungic.Add("Sporá");
        nomsfungic.Add("Pleurotus");
        nomsfungic.Add("Ostreatus");
    }
    void addcognoms(){
        //28
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
        cognoms.Add("Coves");
        cognoms.Add("Bau");
        cognoms.Add("Bodí");
        cognoms.Add("Calera");

        cognomsosmium.Add("1");
        cognomsosmium.Add("10");
        cognomsosmium.Add("11");
        cognomsosmium.Add("100");
        cognomsosmium.Add("101");
        cognomsosmium.Add("110");
        cognomsosmium.Add("111");
        cognomsosmium.Add("1000");
        cognomsosmium.Add("1001");
        cognomsosmium.Add("1010");
        cognomsosmium.Add("1011");
        cognomsosmium.Add("1100");
        cognomsosmium.Add("1101");
        cognomsosmium.Add("1110");
        cognomsosmium.Add("1111");
        cognomsosmium.Add("10000");
        cognomsosmium.Add("10001");
        cognomsosmium.Add("10010");
        cognomsosmium.Add("10011");
        cognomsosmium.Add("10100");
        cognomsosmium.Add("10101");
        cognomsosmium.Add("10110");
        cognomsosmium.Add("10111");
        cognomsosmium.Add("11000");
        cognomsosmium.Add("11001");
        cognomsosmium.Add("11010");
        cognomsosmium.Add("11011");
        cognomsosmium.Add("11100");

        cognomsvaranu.Add("Ka");
        cognomsvaranu.Add("Ke");
        cognomsvaranu.Add("Ki");
        cognomsvaranu.Add("Ko");
        cognomsvaranu.Add("Ku");
        cognomsvaranu.Add("Sa");
        cognomsvaranu.Add("Se");
        cognomsvaranu.Add("Si");
        cognomsvaranu.Add("So");
        cognomsvaranu.Add("Su");
        cognomsvaranu.Add("Ta");
        cognomsvaranu.Add("Te");
        cognomsvaranu.Add("Ti");
        cognomsvaranu.Add("To");
        cognomsvaranu.Add("Tu");
        cognomsvaranu.Add("Va");
        cognomsvaranu.Add("Ve");
        cognomsvaranu.Add("Vi");
        cognomsvaranu.Add("Vo");
        cognomsvaranu.Add("Vu");

        cognomsredempcio.Add("Ala D'aurada");
        cognomsredempcio.Add("Bec Auri");
        cognomsredempcio.Add("Ull Beneït");
        cognomsredempcio.Add("Ploma Redempta");
        cognomsredempcio.Add("Cola Santa");
        cognomsredempcio.Add("Plumó en Creu");
        cognomsredempcio.Add("Gra Sagrat");
        cognomsredempcio.Add("Cuc de la Fé");

        cognomscolmena.Add("Buzz");
        cognomscolmena.Add("Zubz");
        cognomscolmena.Add("Tss");
        cognomscolmena.Add("Pss");
        cognomscolmena.Add("Buzbuzz");
        cognomscolmena.Add("Zumzum");
        cognomscolmena.Add("Tssum");
        cognomscolmena.Add("Zap");
        cognomscolmena.Add("Tsz");
        cognomscolmena.Add("Zzz");

        cognomsfungic.Add("Fungi");
        cognomsfungic.Add("Nasodop");
        cognomsfungic.Add("Basidiomycota");
        cognomsfungic.Add("Pierotus");
        cognomsfungic.Add("Pleurotaceae");
    }

    void addprofessions(){
        professions.Add("Ceramista");
        professions.Add("Programador");
        professions.Add("Operari de maquinaria");
        professions.Add("Sanitari");
        professions.Add("Carretiller");
        professions.Add("Miner");
        professions.Add("Electricista");
        professions.Add("Professor");
        professions.Add("Guarda Forestal");
        professions.Add("Bomber");
        professions.Add("Ingenier");
        professions.Add("Jardiner");
        professions.Add("Forense");
        professions.Add("Diplomatic");
        professions.Add("Dentista");

        professionsESP.Add("Ceramista");
        professionsESP.Add("Programador");
        professionsESP.Add("Operario de maquinaria");
        professionsESP.Add("Sanitario");
        professionsESP.Add("Carretillero");
        professionsESP.Add("Minero");
        professionsESP.Add("Electricista");
        professionsESP.Add("Profesor");
        professionsESP.Add("Guarda Forestal");
        professionsESP.Add("Bombero");
        professionsESP.Add("Ingeniero");
        professionsESP.Add("Jardinero");
        professionsESP.Add("Forense");
        professionsESP.Add("Diplomatico");
        professionsESP.Add("Dentista");

        professionsENG.Add("Ceramista");
        professionsENG.Add("Programador");
        professionsENG.Add("Operari de maquinaria");
        professionsENG.Add("Sanitari");
        professionsENG.Add("Carretiller");
        professionsENG.Add("Miner");
        professionsENG.Add("Electricista");
        professionsENG.Add("Professor");
        professionsENG.Add("Guarda Forestal");
        professionsENG.Add("Bomber");
        professionsENG.Add("Ingenier");
        professionsENG.Add("Jardiner");
        professionsENG.Add("Forense");
        professionsENG.Add("Diplomatic");
        professionsENG.Add("Dentista");

        professionsROM.Add("Ceramista");
        professionsROM.Add("Programador");
        professionsROM.Add("Operari de maquinaria");
        professionsROM.Add("Sanitari");
        professionsROM.Add("Carretiller");
        professionsROM.Add("Miner");
        professionsROM.Add("Electricista");
        professionsROM.Add("Professor");
        professionsROM.Add("Guarda Forestal");
        professionsROM.Add("Bomber");
        professionsROM.Add("Ingenier");
        professionsROM.Add("Jardiner");
        professionsROM.Add("Forense");
        professionsROM.Add("Diplomatic");
        professionsROM.Add("Dentista");

        professionsUKR.Add("Ceramista");
        professionsUKR.Add("Programador");
        professionsUKR.Add("Operari de maquinaria");
        professionsUKR.Add("Sanitari");
        professionsUKR.Add("Carretiller");
        professionsUKR.Add("Miner");
        professionsUKR.Add("Electricista");
        professionsUKR.Add("Professor");
        professionsUKR.Add("Guarda Forestal");
        professionsUKR.Add("Bomber");
        professionsUKR.Add("Ingenier");
        professionsUKR.Add("Jardiner");
        professionsUKR.Add("Forense");
        professionsUKR.Add("Diplomatic");
        professionsUKR.Add("Dentista");

        professionsRUS.Add("Ceramista");
        professionsRUS.Add("Programador");
        professionsRUS.Add("Operari de maquinaria");
        professionsRUS.Add("Sanitari");
        professionsRUS.Add("Carretiller");
        professionsRUS.Add("Miner");
        professionsRUS.Add("Electricista");
        professionsRUS.Add("Professor");
        professionsRUS.Add("Guarda Forestal");
        professionsRUS.Add("Bomber");
        professionsRUS.Add("Ingenier");
        professionsRUS.Add("Jardiner");
        professionsRUS.Add("Forense");
        professionsRUS.Add("Diplomatic");
        professionsRUS.Add("Dentista");
    }
    void addscaners(){
        scaner.Add("Amable");
        scaner.Add("Espiritualista");
        scaner.Add("Materialista");
        scaner.Add("Egalitarista");
        scaner.Add("Ecologista");
        scaner.Add("Animalista");
        scaner.Add("Altruista");
        scaner.Add("Afable");
        scaner.Add("Energic");
        scaner.Add("Deportista");
        scaner.Add("Competitiu");
        scaner.Add("Perfeccionista");
        scaner.Add("Xarrador");
        scaner.Add("Competitiu");
        scaner.Add("Amoros");
        scaner.Add("Simpatic");
        scaner.Add("Xenófob");
        scaner.Add("Elitista");
        scaner.Add("Vengatiu");
        scaner.Add("Codicios");

        scanerESP.Add("Amable");
        scanerESP.Add("Espiritualista");
        scanerESP.Add("Materialista");
        scanerESP.Add("Egalitarista");
        scanerESP.Add("Ecologista");
        scanerESP.Add("Animalista");
        scanerESP.Add("Altruista");
        scanerESP.Add("Afable");
        scanerESP.Add("Energic");
        scanerESP.Add("Deportista");
        scanerESP.Add("Competitiu");
        scanerESP.Add("Perfeccionista");
        scanerESP.Add("Xarrador");
        scanerESP.Add("Competitiu");
        scanerESP.Add("Amoros");
        scanerESP.Add("Simpatic");
        scanerESP.Add("Xenófob");
        scanerESP.Add("Elitista");
        scanerESP.Add("Vengatiu");
        scanerESP.Add("Codicios");

        scanerENG.Add("Amable");
        scanerENG.Add("Espiritualista");
        scanerENG.Add("Materialista");
        scanerENG.Add("Egalitarista");
        scanerENG.Add("Ecologista");
        scanerENG.Add("Animalista");
        scanerENG.Add("Altruista");
        scanerENG.Add("Afable");
        scanerENG.Add("Energic");
        scanerENG.Add("Deportista");
        scanerENG.Add("Competitiu");
        scanerENG.Add("Perfeccionista");
        scanerENG.Add("Xarrador");
        scanerENG.Add("Competitiu");
        scanerENG.Add("Amoros");
        scanerENG.Add("Simpatic");
        scanerENG.Add("Xenófob");
        scanerENG.Add("Elitista");
        scanerENG.Add("Vengatiu");
        scanerENG.Add("Codicios");

        scanerROM.Add("Amable");
        scanerROM.Add("Espiritualista");
        scanerROM.Add("Materialista");
        scanerROM.Add("Egalitarista");
        scanerROM.Add("Ecologista");
        scanerROM.Add("Animalista");
        scanerROM.Add("Altruista");
        scanerROM.Add("Afable");
        scanerROM.Add("Energic");
        scanerROM.Add("Deportista");
        scanerROM.Add("Competitiu");
        scanerROM.Add("Perfeccionista");
        scanerROM.Add("Xarrador");
        scanerROM.Add("Competitiu");
        scanerROM.Add("Amoros");
        scanerROM.Add("Simpatic");
        scanerROM.Add("Xenófob");
        scanerROM.Add("Elitista");
        scanerROM.Add("Vengatiu");
        scanerROM.Add("Codicios");

        scanerUKR.Add("Amable");
        scanerUKR.Add("Espiritualista");
        scanerUKR.Add("Materialista");
        scanerUKR.Add("Egalitarista");
        scanerUKR.Add("Ecologista");
        scanerUKR.Add("Animalista");
        scanerUKR.Add("Altruista");
        scanerUKR.Add("Afable");
        scanerUKR.Add("Energic");
        scanerUKR.Add("Deportista");
        scanerUKR.Add("Competitiu");
        scanerUKR.Add("Perfeccionista");
        scanerUKR.Add("Xarrador");
        scanerUKR.Add("Competitiu");
        scanerUKR.Add("Amoros");
        scanerUKR.Add("Simpatic");
        scanerUKR.Add("Xenófob");
        scanerUKR.Add("Elitista");
        scanerUKR.Add("Vengatiu");
        scanerUKR.Add("Codicios");

        scanerRUS.Add("Amable");
        scanerRUS.Add("Espiritualista");
        scanerRUS.Add("Materialista");
        scanerRUS.Add("Egalitarista");
        scanerRUS.Add("Ecologista");
        scanerRUS.Add("Animalista");
        scanerRUS.Add("Altruista");
        scanerRUS.Add("Afable");
        scanerRUS.Add("Energic");
        scanerRUS.Add("Deportista");
        scanerRUS.Add("Competitiu");
        scanerRUS.Add("Perfeccionista");
        scanerRUS.Add("Xarrador");
        scanerRUS.Add("Competitiu");
        scanerRUS.Add("Amoros");
        scanerRUS.Add("Simpatic");
        scanerRUS.Add("Xenófob");
        scanerRUS.Add("Elitista");
        scanerRUS.Add("Vengatiu");
        scanerRUS.Add("Codicios");
    }
    public static string generatenom(){
        int value = Random.Range(0, (noms.Count)-1);
        string nom = noms[value]+" "+generatecognom()+" "+generatecognom();
        return nom;
    }
    public static string generatenomdona(){
        int value = Random.Range(0, (nomsdona.Count)-1);
        string nom = nomsdona[value]+" "+generatecognom()+" "+generatecognom();
        return nom;
    }
    public static string generatenommamutidamies(){
        int value = Random.Range(0, (nomsmamutidamies.Count)-1);
        string nom = nomsmamutidamies[value]+" "+nomsmamutidamies[Random.Range(0,nomsmamutidamies.Count)]+"uk";
        return nom;
    }
    public static string generatenomosmium(){
        int value = Random.Range(0, (nomsosmium.Count)-1);
        string nom = nomsosmium[value]+" "+generatecognomosmium();
        return nom;
    }
    public static string generatenomoredempcio(){
        int value = Random.Range(0, (nomsredempcio.Count)-1);
        string nom = nomsredempcio[value]+" "+generatecognomredempcio();
        return nom;
    }
    public static string generatenomocolmena(){
        int value = Random.Range(0, (nomscolmena.Count)-1);
        string nom = nomscolmena[value]+" "+generatecognomcolmena();
        return nom;
    }
    public static string generatenomofungic(){
        int value = Random.Range(0, (nomsfungic.Count)-1);
        string nom = nomsfungic[value]+" "+generatecognomfungic();
        return nom;
    }
    public static string generatenomovaranu(){
        int value = Random.Range(0, (nomsvaranu.Count)-1);
        string nom = nomsvaranu[value]+" "+generatecognomvaranu();
        return nom;
    }
    public static string generatecognom(){
        int value = Random.Range(0, (cognoms.Count)-1);
        string cognom = cognoms[value];
        return cognom;
    }
    public static string generatecognomosmium(){
        int value = Random.Range(0, (cognomsosmium.Count)-1);
        string cognom = cognomsosmium[value];
        return cognom;
    }
    public static string generatecognomredempcio(){
        int value = Random.Range(0, (cognomsredempcio.Count)-1);
        string cognom = cognomsredempcio[value];
        return cognom;
    }
    public static string generatecognomcolmena(){
        int value = Random.Range(0, (cognomscolmena.Count)-1);
        string cognom = cognomscolmena[value];
        return cognom;
    }
    public static string generatecognomfungic(){
        int value = Random.Range(0, (cognomsfungic.Count)-1);
        string cognom = cognomsfungic[value];
        return cognom;
    }
    public static string generatecognomvaranu(){
        int value = Random.Range(0, (cognomsvaranu.Count)-1);
        string cognom = cognomsvaranu[value];
        return cognom;
    }
    public static string generateprofessio(string languge){
        if (languge == "VAL"){
            int value = Random.Range(0,(professions.Count)-1);
            string professio = professions[value];
            return professio;
        }
        if (languge == "ESP"){
            int value = Random.Range(0,(professionsESP.Count)-1);
            string professio = professionsESP[value];
            return professio;
        }
        if (languge == "ROM"){
            int value = Random.Range(0,(professionsROM.Count)-1);
            string professio = professionsROM[value];
            return professio;
        }
        if (languge == "UKR"){
            int value = Random.Range(0,(professionsUKR.Count)-1);
            string professio = professionsUKR[value];
            return professio;
        }
        if (languge == "RUS"){
            int value = Random.Range(0,(professionsRUS.Count)-1);
            string professio = professionsRUS[value];
            return professio;
        }
        else {
            int value = Random.Range(0,(professionsENG.Count)-1);
            string professio = professionsENG[value];
            return professio;
        }
        
    }
    public static string generatescaner(string languge){
        if(languge == "VAL"){
            int value = Random.Range(0,(scaner.Count)-1);
            string scanervalue = scaner[value];
            return scanervalue;
        }
        if(languge == "ESP"){
            int value = Random.Range(0,(scanerESP.Count)-1);
            string scanervalue = scanerESP[value];
            return scanervalue;
        }
        if(languge == "ROM"){
            int value = Random.Range(0,(scanerROM.Count)-1);
            string scanervalue = scanerROM[value];
            return scanervalue;
        }
        if(languge == "UKR"){
            int value = Random.Range(0,(scanerUKR.Count)-1);
            string scanervalue = scanerUKR[value];
            return scanervalue;
        }
        if(languge == "RUS"){
            int value = Random.Range(0,(scanerRUS.Count)-1);
            string scanervalue = scanerRUS[value];
            return scanervalue;
        }
        else{
            int value = Random.Range(0,(scanerENG.Count)-1);
            string scanervalue = scanerENG[value];
            return scanervalue;
        }
        
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
    public static string generateDNI(string DNI=""){
        if(DNI != ""){
            int random = Random.Range(1,8);
            string DNImal = DNI.Substring(0,random);
            for (int x = 0; x<=(5-random);x++){
                DNImal = DNImal+Random.Range(0,9);
            }
            DNImal = DNImal+(char)('A'+Random.Range(0,26));
            return DNImal;
        }
        for (int x=0; x<=5; x++){
        DNI = DNI+ Random.Range(0,9);
        }
        DNI = DNI+ (char)('A'+Random.Range(0,26));
        return DNI;
    }
}
