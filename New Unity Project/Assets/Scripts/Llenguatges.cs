using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Llenguatges : MonoBehaviour
{
    // Start is called before the first frame update
    public static Dictionary<string, string> llenguatges = new Dictionary<string, string>();
    public static string languge = "ENG";
    public void setlangugeVAL(){
        languge = "VAL";
    }
    public void setlangugeESP(){
        languge = "ESP";
    }
    public void setlangugeENG(){
        languge = "ENG";
    }
    public void setlangugeROM(){
        languge = "ROM";
    }
    public void setlangugeUKR(){
        languge = "UKR";
    }
    public void setlangugeRUS(){
        languge = "RUS";
    }
    void Start(){
        llenguatges.Add("VAL-Start","Començar");
        llenguatges.Add("ESP-Start", "Empezar");
        llenguatges.Add("ENG-Start", "Start");
        llenguatges.Add("ROM-Start", "");
        llenguatges.Add("UKR-Start","");
        llenguatges.Add("RUS-Start","");

        llenguatges.Add("VAL-Idioma","Idiomes");
        llenguatges.Add("ESP-Idioma", "Idiomas");
        llenguatges.Add("ENG-Idioma", "Languages");
        llenguatges.Add("ROM-Idioma", "");
        llenguatges.Add("UKR-Idioma","");
        llenguatges.Add("RUS-Idioma","");

        llenguatges.Add("VAL-Back","Enrere");
        llenguatges.Add("ESP-Back", "Atrás");
        llenguatges.Add("ENG-Back", "Back");
        llenguatges.Add("ROM-Back", "");
        llenguatges.Add("UKR-Back","");
        llenguatges.Add("RUS-Back","");

        llenguatges.Add("VAL-OK","Entesos");
        llenguatges.Add("ESP-OK", "Entendido");
        llenguatges.Add("ENG-OK", "OK");
        llenguatges.Add("ROM-OK", "");
        llenguatges.Add("UKR-OK","");
        llenguatges.Add("RUS-OK","");

        llenguatges.Add("VAL-Ferramentes","Ferramentes");
        llenguatges.Add("ESP-Ferramentes", "Herramientas");
        llenguatges.Add("ENG-Ferramentes", "Tools");
        llenguatges.Add("ROM-Ferramentes", "");
        llenguatges.Add("UKR-Ferramentes","");
        llenguatges.Add("RUS-Ferramentes","");

        llenguatges.Add("VAL-Escaner","Escanejar");
        llenguatges.Add("ESP-Escaner", "Escanear");
        llenguatges.Add("ENG-Escaner", "Scan");
        llenguatges.Add("ROM-Escaner", "");
        llenguatges.Add("UKR-Escaner","");
        llenguatges.Add("RUS-Escaner","");

        llenguatges.Add("VAL-Passaport","Passaport");
        llenguatges.Add("ESP-Passaport", "Pasaporte");
        llenguatges.Add("ENG-Passaport", "Passport");
        llenguatges.Add("ROM-Passaport", "");
        llenguatges.Add("UKR-Passaport","");
        llenguatges.Add("RUS-Passaport","");
        
        llenguatges.Add("VAL-Masculí","Masculí");
        llenguatges.Add("ESP-Masculí", "Masculino");
        llenguatges.Add("ENG-Masculí", "Male");
        llenguatges.Add("ROM-Masculí", "");
        llenguatges.Add("UKR-Masculí","");
        llenguatges.Add("RUS-Masculí","");
        
        llenguatges.Add("VAL-Femení","Femení");
        llenguatges.Add("ESP-Femení", "Femenino");
        llenguatges.Add("ENG-Femení", "Female");
        llenguatges.Add("ROM-Femení", "");
        llenguatges.Add("UKR-Femení","");
        llenguatges.Add("RUS-Femení","");

        llenguatges.Add("VAL-Estandar","Estandar");
        llenguatges.Add("ESP-Estandar", "Estandar");
        llenguatges.Add("ENG-Estandar", "Standar");
        llenguatges.Add("ROM-Estandar", "");
        llenguatges.Add("UKR-Estandar","");
        llenguatges.Add("RUS-Estandar","");

        llenguatges.Add("VAL-Orelles","Orellut");
        llenguatges.Add("ESP-Orelles", "Orejudo");
        llenguatges.Add("ENG-Orelles", "");
        llenguatges.Add("ROM-Orelles", "");
        llenguatges.Add("UKR-Orelles","");
        llenguatges.Add("RUS-Orelles","");

        llenguatges.Add("VAL-Banya","Banya Trencada");
        llenguatges.Add("ESP-Banya", "Cuerno Roto");
        llenguatges.Add("ENG-Banya", "");
        llenguatges.Add("ROM-Banya", "");
        llenguatges.Add("UKR-Banya","");
        llenguatges.Add("RUS-Banya","");

        llenguatges.Add("VAL-Curta","Trompa curta");
        llenguatges.Add("ESP-Curta", "Trompa corta");
        llenguatges.Add("ENG-Curta", "");
        llenguatges.Add("ROM-Curta", "");
        llenguatges.Add("UKR-Curta","");
        llenguatges.Add("RUS-Curta","");

        llenguatges.Add("VAL-Roig","Roig");
        llenguatges.Add("ESP-Roig", "Rojo");
        llenguatges.Add("ENG-Roig", "Red");
        llenguatges.Add("ROM-Roig", "");
        llenguatges.Add("UKR-Roig","");
        llenguatges.Add("RUS-Roig","");

        llenguatges.Add("VAL-Verd","Verd");
        llenguatges.Add("ESP-Verd", "Verde");
        llenguatges.Add("ENG-Verd", "Green");
        llenguatges.Add("ROM-Verd", "");
        llenguatges.Add("UKR-Verd","");
        llenguatges.Add("RUS-Verd","");

        llenguatges.Add("VAL-Groc","Groc");
        llenguatges.Add("ESP-Groc", "Amarillo");
        llenguatges.Add("ENG-Groc", "Yellow");
        llenguatges.Add("ROM-Groc", "");
        llenguatges.Add("UKR-Groc","");
        llenguatges.Add("RUS-Groc","");

        llenguatges.Add("VAL-Morat","Morat");
        llenguatges.Add("ESP-Morat", "Morado");
        llenguatges.Add("ENG-Morat", "Purple");
        llenguatges.Add("ROM-Morat", "");
        llenguatges.Add("UKR-Morat","");
        llenguatges.Add("RUS-Morat","");

        llenguatges.Add("VAL-Negre","Negre");
        llenguatges.Add("ESP-Negre", "Negro");
        llenguatges.Add("ENG-Negre", "Black");
        llenguatges.Add("ROM-Negre", "");
        llenguatges.Add("UKR-Negre","");
        llenguatges.Add("RUS-Negre","");

        llenguatges.Add("VAL-Rosa","Rosa");
        llenguatges.Add("ESP-Rosa", "Rosa");
        llenguatges.Add("ENG-Rosa", "Pink");
        llenguatges.Add("ROM-Rosa", "");
        llenguatges.Add("UKR-Rosa","");
        llenguatges.Add("RUS-Rosa","");

        llenguatges.Add("VAL-Flac","Flac");
        llenguatges.Add("ESP-Flac", "Flaco");
        llenguatges.Add("ENG-Flac", "Thin");
        llenguatges.Add("ROM-Flac", "");
        llenguatges.Add("UKR-Flac","");
        llenguatges.Add("RUS-Flac","");

        llenguatges.Add("VAL-Gros","Gros");
        llenguatges.Add("ESP-Gros", "Gordo");
        llenguatges.Add("ENG-Gros", "Fat");
        llenguatges.Add("ROM-Gros", "");
        llenguatges.Add("UKR-Gros","");
        llenguatges.Add("RUS-Gros","");

        llenguatges.Add("VAL-Pelut","Pelut");
        llenguatges.Add("ESP-Pelut", "Peludo");
        llenguatges.Add("ENG-Pelut", "Heary");
        llenguatges.Add("ROM-Pelut", "");
        llenguatges.Add("UKR-Pelut","");
        llenguatges.Add("RUS-Pelut","");

        
        llenguatges.Add("VAL-Tronc","Amb Tronc");
        llenguatges.Add("ESP-Tronc", "Con Tronco");
        llenguatges.Add("ENG-Tronc", "");
        llenguatges.Add("ROM-Tronc", "");
        llenguatges.Add("UKR-Tronc","");
        llenguatges.Add("RUS-Tronc","");

        llenguatges.Add("VAL-champi","Xampinyó");
        llenguatges.Add("ESP-champi", "Champiñón");
        llenguatges.Add("ENG-champi", "Fat");
        llenguatges.Add("ROM-champi", "");
        llenguatges.Add("UKR-champi","");
        llenguatges.Add("RUS-champi","");

        llenguatges.Add("VAL-multiple","Multiple");
        llenguatges.Add("ESP-multiple", "Multiple");
        llenguatges.Add("ENG-multiple", "");
        llenguatges.Add("ROM-multiple", "");
        llenguatges.Add("UKR-multiple","");
        llenguatges.Add("RUS-multiple","");


        llenguatges.Add("VAL-Treball","Permís de treball");
        llenguatges.Add("ESP-Treball", "Permiso de trabajo");
        llenguatges.Add("ENG-Treball", "Working Permit");
        llenguatges.Add("ROM-Treball", "");
        llenguatges.Add("UKR-Treball","");
        llenguatges.Add("RUS-Treball","");

        llenguatges.Add("VAL-PCR","PCR");
        llenguatges.Add("ESP-PCR", "PCR");
        llenguatges.Add("ENG-PCR", "PCR");
        llenguatges.Add("ROM-PCR", "");
        llenguatges.Add("UKR-PCR","");
        llenguatges.Add("RUS-PCR","");

        llenguatges.Add("VAL-Infinit","Infinit");
        llenguatges.Add("ESP-Infinit", "Infinito");
        llenguatges.Add("ENG-Infinit", "Infinit");
        llenguatges.Add("ROM-Infinit", "");
        llenguatges.Add("UKR-Infinit","");
        llenguatges.Add("RUS-Infinit","");

        llenguatges.Add("VAL-Intro","Benvingut al control aduaner de La Unió Galàctica. Hui dia 30/01/2321, començarà la teua feina. Has de comprovar que tot aquell que vinga a la frontera duga un passaport vàlid, És a dir, no estiga caduc i concorde amb el visitant.");
        llenguatges.Add("ESP-Intro", "Bienvenido al control de aduanas de la Unión Galáctica. Hoy dia 30/01/2321 empezara tu trabajo. Has de comprobar que todo aquel que venga a la frontera lleve un pasaporte válido, És decir, que no esté caducado y que concuerde con el visitante");
        llenguatges.Add("ROM-Intro", "");
        llenguatges.Add("UKR-Intro","");
        llenguatges.Add("RUS-Intro","");

        llenguatges.Add("VAL-Intro2","Les Tribus Mammutidànies han fet un pacte amb La Unió Galàctica. D'ara en avant els seus ciutadans poden creuar la frontera al igual que els nostres. Aquest es el seu aspecte:");
        llenguatges.Add("ESP-Intro2", "Empezar");
        llenguatges.Add("ROM-Intro2", "");
        llenguatges.Add("UKR-Intro2","");
        llenguatges.Add("RUS-Intro2","");

        llenguatges.Add("VAL-Intro3","La Republica Binaria d'Osmium s'ha interesat en nosaltres. D'ara en avant els seus ciutadans podrán creuar la frontera. A més a més, D'ara en avant aquells que vulguen treballar han de aportar un permís valid.");
        llenguatges.Add("ESP-Intro3", "Empezar");
        llenguatges.Add("ROM-Intro3", "");
        llenguatges.Add("UKR-Intro3","");
        llenguatges.Add("RUS-Intro3","");

        llenguatges.Add("VAL-Intro4","La teocràcia de Redempció ha fet un pacte amb nosaltres. Els seus ciutadans son venvinguts");
        llenguatges.Add("ESP-Intro4", "Empezar");
        llenguatges.Add("ROM-Intro4", "");
        llenguatges.Add("UKR-Intro4","");
        llenguatges.Add("RUS-Intro4","");

        llenguatges.Add("VAL-Intro5","La colmena ha fet un pacte amb nosaltres. Els seus ciutadans son venvinguts. L'imperi ha decidit que tot aquell que siga Xenófob, Elitista, Vengatiu o Codiciós no podrá pasar. Fes Escaners per averiguar-ho");
        llenguatges.Add("ESP-Intro5", "Empezar");
        llenguatges.Add("ROM-Intro5", "");
        llenguatges.Add("UKR-Intro5","");
        llenguatges.Add("RUS-Intro5","");

        llenguatges.Add("VAL-Intro6","Els Fungidae han fet un pacte amb nosaltres. Son Benvinguts.");
        llenguatges.Add("ESP-Intro6", "Empezar");
        llenguatges.Add("ROM-Intro6", "");
        llenguatges.Add("UKR-Intro6","");
        llenguatges.Add("RUS-Intro6","");

        llenguatges.Add("VAL-Intro7","L'imperi Varanu s'ha sumat a obrir les fronteres amb nosaltres.");
        llenguatges.Add("ESP-Intro7", "Empezar");
        llenguatges.Add("ROM-Intro7", "");
        llenguatges.Add("UKR-Intro7","");
        llenguatges.Add("RUS-Intro7","");

        llenguatges.Add("VAL-Intro8","Un virus s'ha escampat per el espai. Realitza PCRs i no permetis la entrada a ningún malalt");
        llenguatges.Add("ESP-Intro8", "Empezar");
        llenguatges.Add("ROM-Intro8", "");
        llenguatges.Add("UKR-Intro8","");
        llenguatges.Add("RUS-Intro8","");

        llenguatges.Add("VAL-Intro9","Ben fet, no hi ha cap novetat");
        llenguatges.Add("ESP-Intro9", "Empezar");
        llenguatges.Add("ROM-Intro9", "");
        llenguatges.Add("UKR-Intro9","");
        llenguatges.Add("RUS-Intro9","");

        llenguatges.Add("VAL-Intro10","Ben fet, no hi ha cap novetat");
        llenguatges.Add("ESP-Intro10", "Empezar");
        llenguatges.Add("ROM-Intro10", "");
        llenguatges.Add("UKR-Intro10","");
        llenguatges.Add("RUS-Intro10","");

        llenguatges.Add("VAL-Intro11","Enhorabona!, has acabat el mode Historia. Mode infinit desbloquejat.");
        llenguatges.Add("ESP-Intro11", "Empezar");
        llenguatges.Add("ROM-Intro11", "");
        llenguatges.Add("UKR-Intro11","");
        llenguatges.Add("RUS-Intro11","");

        llenguatges.Add("VAL-Puntuació","La teua puntuació és:");
        llenguatges.Add("ESP-Puntuació", "Tu puntuación és:");
        llenguatges.Add("ENG-Puntuació", "");
        llenguatges.Add("ROM-Puntuació", "");
        llenguatges.Add("UKR-Puntuació","");
        llenguatges.Add("RUS-Puntuació","");

        llenguatges.Add("VAL-Nom","Introdueix el teu nom");
        llenguatges.Add("ESP-Nom", "Introduce tu nombre");
        llenguatges.Add("ENG-Nom", "");
        llenguatges.Add("ROM-Nom", "");
        llenguatges.Add("UKR-Nom","");
        llenguatges.Add("RUS-Nom","");

        llenguatges.Add("VAL-Puntuacions","Puntuacions");
        llenguatges.Add("ESP-Puntuacions", "Puntuaciones");
        llenguatges.Add("ENG-Puntuacions", "");
        llenguatges.Add("ROM-Puntuacions", "");
        llenguatges.Add("UKR-Puntuacions","");
        llenguatges.Add("RUS-Puntuacions","");

        llenguatges.Add("VAL-Xeno","Xenòfob");
        llenguatges.Add("ESP-Xeno", "Xenofobo");
        llenguatges.Add("ENG-Xeno", "");
        llenguatges.Add("ROM-Xeno", "");
        llenguatges.Add("UKR-Xeno","");
        llenguatges.Add("RUS-Xeno","");

        llenguatges.Add("VAL-Elitista","Elitista");
        llenguatges.Add("ESP-Elitista", "Puntuaciones");
        llenguatges.Add("ENG-Elitista", "");
        llenguatges.Add("ROM-Elitista", "");
        llenguatges.Add("UKR-Elitista","");
        llenguatges.Add("RUS-Elitista","");

        llenguatges.Add("VAL-Vengatiu","Vengatiu");
        llenguatges.Add("ESP-Vengatiu", "Puntuaciones");
        llenguatges.Add("ENG-Vengatiu", "");
        llenguatges.Add("ROM-Vengatiu", "");
        llenguatges.Add("UKR-Vengatiu","");
        llenguatges.Add("RUS-Vengatiu","");

        llenguatges.Add("VAL-Codicios","Codicios");
        llenguatges.Add("ESP-Codicios", "Puntuaciones");
        llenguatges.Add("ENG-Codicios", "");
        llenguatges.Add("ROM-Codicios", "");
        llenguatges.Add("UKR-Codicios","");
        llenguatges.Add("RUS-Codicios","");

        llenguatges.Add("VAL-Malalt","Malalt");
        llenguatges.Add("ESP-Malalt", "Enfermo");
        llenguatges.Add("ENG-Malalt", "");
        llenguatges.Add("ROM-Malalt", "");
        llenguatges.Add("UKR-Malalt","");
        llenguatges.Add("RUS-Malalt","");

        llenguatges.Add("VAL-Saludable","Saludable");
        llenguatges.Add("ESP-Saludable","Saludable");
        llenguatges.Add("ENG-Saludable", "");
        llenguatges.Add("ROM-Saludable", "");
        llenguatges.Add("UKR-Saludable","");
        llenguatges.Add("RUS-Saludable","");

        string value;
        Debug.Log(llenguatges.TryGetValue("VAL-Start",out value));
        Debug.Log(value);
    }

}
