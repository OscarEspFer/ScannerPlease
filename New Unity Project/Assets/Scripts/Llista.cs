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

        professionsENG.Add("Ceramist");
        professionsENG.Add("Programmer");
        professionsENG.Add("Machine Worker");
        professionsENG.Add("Nurse");
        professionsENG.Add("Fork-lift operator");
        professionsENG.Add("Miner");
        professionsENG.Add("Electrician");
        professionsENG.Add("Teacher");
        professionsENG.Add("Forest Ranger");
        professionsENG.Add("Firefigter");
        professionsENG.Add("Engineer");
        professionsENG.Add("Gardener");
        professionsENG.Add("Medical Examiner");
        professionsENG.Add("Diplomat");
        professionsENG.Add("Dentist");

        professionsROM.Add("Ceramist");
        professionsROM.Add("Programator");
        professionsROM.Add("Mașinist");
        professionsROM.Add("Sanitar");
        professionsROM.Add("Motoștivuitorist");
        professionsROM.Add("Miner");
        professionsROM.Add("Electricist");
        professionsROM.Add("Profesor");
        professionsROM.Add("Pădurar");
        professionsROM.Add("Pompier");
        professionsROM.Add("Inginer");
        professionsROM.Add("Grădinar");
        professionsROM.Add("Medic legist");
        professionsROM.Add("Diplomat");
        professionsROM.Add("Dentist");

        professionsUKR.Add("Керамік");
        professionsUKR.Add("Програміст");
        professionsUKR.Add("Оператор на Станку");
        professionsUKR.Add("Санітар");
        professionsUKR.Add("Візник");
        professionsUKR.Add("Шахтар");
        professionsUKR.Add("Електрик");
        professionsUKR.Add("Профессор");
        professionsUKR.Add("Лісник");
        professionsUKR.Add("Пожежник");
        professionsUKR.Add("Інженер");
        professionsUKR.Add("Садівник");
        professionsUKR.Add("Патологеонатом");
        professionsUKR.Add("Дипломат");
        professionsUKR.Add("Стоматолог");

        professionsRUS.Add("Керамик");
        professionsRUS.Add("Програмист");
        professionsRUS.Add("Оператор на станке");
        professionsRUS.Add("Санитар");
        professionsRUS.Add("Извозчик");
        professionsRUS.Add("Шахтёр");
        professionsRUS.Add("Єлектрик");
        professionsRUS.Add("Профессор");
        professionsRUS.Add("Лесник");
        professionsRUS.Add("Пожарник");
        professionsRUS.Add("Инженер");
        professionsRUS.Add("Садовник");
        professionsRUS.Add("Патологеонатом");
        professionsRUS.Add("Дипломат");
        professionsRUS.Add("Стоматолог");
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
        scanerESP.Add("Energico");
        scanerESP.Add("Deportista");
        scanerESP.Add("Competitivo");
        scanerESP.Add("Perfeccionista");
        scanerESP.Add("Hablador");
        scanerESP.Add("Competitivo");
        scanerESP.Add("Amoroso");
        scanerESP.Add("Simpatico");
        scanerESP.Add("Xenófobo");
        scanerESP.Add("Elitista");
        scanerESP.Add("Vengativo");
        scanerESP.Add("Codicioso");

        scanerENG.Add("Friendly");
        scanerENG.Add("Spiritualist");
        scanerENG.Add("Materialist");
        scanerENG.Add("Egalitarist");
        scanerENG.Add("Ecologist");
        scanerENG.Add("Animalist");
        scanerENG.Add("Altruistic");
        scanerENG.Add("Affable");
        scanerENG.Add("Vigorous");
        scanerENG.Add("Sporty");
        scanerENG.Add("Competitive");
        scanerENG.Add("Perfectionist");
        scanerENG.Add("Talkative");
        scanerENG.Add("Competitive");
        scanerENG.Add("Affectionate");
        scanerENG.Add("Kind");
        scanerENG.Add("Xenophobic");
        scanerENG.Add("Elitist");
        scanerENG.Add("Vindictive");
        scanerENG.Add("Greedy");

        scanerROM.Add("Amabil");
        scanerROM.Add("Spiritual");
        scanerROM.Add("Materialist");
        scanerROM.Add("Egalitarist");
        scanerROM.Add("Ecologist");
        scanerROM.Add("Animalist");
        scanerROM.Add("Altruist");
        scanerROM.Add("Afabil");
        scanerROM.Add("Energic");
        scanerROM.Add("Sportiv");
        scanerROM.Add("Competitiv");
        scanerROM.Add("Perfectionist");
        scanerROM.Add("Vorbăreț");
        scanerROM.Add("Competitiv");
        scanerROM.Add("Iubareț");
        scanerROM.Add("Simpatic");
        scanerROM.Add("Xenofob");
        scanerROM.Add("Elitist");
        scanerROM.Add("Răzbunător");
        scanerROM.Add("Lacom");

        scanerUKR.Add("Ввічливий");
        scanerUKR.Add("Спіритичний");
        scanerUKR.Add("Матеріаліст");
        scanerUKR.Add("Егалітарний");
        scanerUKR.Add("Екологіст");
        scanerUKR.Add("Анімалістичний");
        scanerUKR.Add("Альтруїст");
        scanerUKR.Add("Привітний");
        scanerUKR.Add("Енергічний");
        scanerUKR.Add("Спортсмен");
        scanerUKR.Add("Конкурентоспроможний");
        scanerUKR.Add("Перфекціоніст");
        scanerUKR.Add("Балакун");
        scanerUKR.Add("Конкурентоспроможний");
        scanerUKR.Add("Люблячий");
        scanerUKR.Add("Симпатичний");
        scanerUKR.Add("Xenófob");
        scanerUKR.Add("Елітарний");
        scanerUKR.Add("Мстивий");
        scanerUKR.Add("Жадібний");

        scanerRUS.Add("Вежливый");
        scanerRUS.Add("Спиритуалистический");
        scanerRUS.Add("Материалист");
        scanerRUS.Add("Эгалитарный");
        scanerRUS.Add("Эколог");
        scanerRUS.Add("Анималистический");
        scanerRUS.Add("Альтруист");
        scanerRUS.Add("Приветливый");
        scanerRUS.Add("Энергичный");
        scanerRUS.Add("Спортсмен");
        scanerRUS.Add("Конкурентоспособный");
        scanerRUS.Add("Перфекционист");
        scanerRUS.Add("Болтун");
        scanerRUS.Add("Конкурентоспособный");
        scanerRUS.Add("Любящий");
        scanerRUS.Add("Сочувствующий");
        scanerRUS.Add("Ксенофоб");
        scanerRUS.Add("Элитарный");
        scanerRUS.Add("Мстительный");
        scanerRUS.Add("Жадный");
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
