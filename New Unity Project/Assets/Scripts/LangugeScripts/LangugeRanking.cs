using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class LangugeRanking : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject text;
    public GameObject nom;
    void Start()
    {
        if (Llenguatges.languge == "VAL"){
            string value;
            Llenguatges.llenguatges.TryGetValue("VAL-Back",out value);
            GameObject.Find("Button").GetComponentInChildren<Text>().text = value;
            Llenguatges.llenguatges.TryGetValue("VAL-Puntuacions",out value);
            GameObject.Find("Btpuntuacio").GetComponentInChildren<Text>().text = value;
            Llenguatges.llenguatges.TryGetValue("VAL-Puntuació",out value);
            text.GetComponent<UnityEngine.UI.Text>().text = value;
            Llenguatges.llenguatges.TryGetValue("VAL-Nom",out value);
            text.GetComponent<UnityEngine.UI.Text>().text = value;
            
        }
        if (Llenguatges.languge == "ESP"){
            string value;
            Llenguatges.llenguatges.TryGetValue("ESP-Back",out value);
            GameObject.Find("Button").GetComponentInChildren<Text>().text = value;
            Llenguatges.llenguatges.TryGetValue("ESP-Puntuacions",out value);
            GameObject.Find("Btpuntuacio").GetComponentInChildren<Text>().text = value;
            Llenguatges.llenguatges.TryGetValue("ESP-Puntuació",out value);
            text.GetComponent<UnityEngine.UI.Text>().text = value;
            Llenguatges.llenguatges.TryGetValue("ESP-Nom",out value);
            text.GetComponent<UnityEngine.UI.Text>().text = value;
        }
        if (Llenguatges.languge == "ENG"){
            string value;
            Llenguatges.llenguatges.TryGetValue("ENG-Back",out value);
            GameObject.Find("Button").GetComponentInChildren<Text>().text = value;
            Llenguatges.llenguatges.TryGetValue("ENG-Puntuacions",out value);
            GameObject.Find("Btpuntuacio").GetComponentInChildren<Text>().text = value;
            Llenguatges.llenguatges.TryGetValue("ENG-Puntuació",out value);
            text.GetComponent<UnityEngine.UI.Text>().text = value;
            Llenguatges.llenguatges.TryGetValue("ENG-Nom",out value);
            text.GetComponent<UnityEngine.UI.Text>().text = value;
        }
        if (Llenguatges.languge == "ROM"){
            string value;
            Llenguatges.llenguatges.TryGetValue("ROM-Back",out value);
            GameObject.Find("Button").GetComponentInChildren<Text>().text = value;
            Llenguatges.llenguatges.TryGetValue("ROM-Puntuacions",out value);
            GameObject.Find("Btpuntuacio").GetComponentInChildren<Text>().text = value;
            Llenguatges.llenguatges.TryGetValue("ROM-Puntuació",out value);
            text.GetComponent<UnityEngine.UI.Text>().text = value;
            Llenguatges.llenguatges.TryGetValue("ROM-Nom",out value);
            text.GetComponent<UnityEngine.UI.Text>().text = value;
        }
        if (Llenguatges.languge == "UKR"){
            string value;
            Llenguatges.llenguatges.TryGetValue("UKR-Back",out value);
            GameObject.Find("Button").GetComponentInChildren<Text>().text = value;
            Llenguatges.llenguatges.TryGetValue("UKR-Puntuacions",out value);
            GameObject.Find("Btpuntuacio").GetComponentInChildren<Text>().text = value;
            Llenguatges.llenguatges.TryGetValue("UKR-Puntuació",out value);
            text.GetComponent<UnityEngine.UI.Text>().text = value;
            Llenguatges.llenguatges.TryGetValue("UKR-Nom",out value);
            text.GetComponent<UnityEngine.UI.Text>().text = value;
        }
        if (Llenguatges.languge == "RUS"){
            string value;
            Llenguatges.llenguatges.TryGetValue("RUS-Back",out value);
            GameObject.Find("Button").GetComponentInChildren<Text>().text = value;
            Llenguatges.llenguatges.TryGetValue("RUS-Puntuacions",out value);
            GameObject.Find("Btpuntuacio").GetComponentInChildren<Text>().text = value;
            Llenguatges.llenguatges.TryGetValue("RUS-Puntuació",out value);
            text.GetComponent<UnityEngine.UI.Text>().text = value;
            Llenguatges.llenguatges.TryGetValue("RUS-Nom",out value);
            text.GetComponent<UnityEngine.UI.Text>().text = value;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
