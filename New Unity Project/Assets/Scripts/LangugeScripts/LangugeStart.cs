using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LangugeStart : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(esperador());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator esperador(){
        yield return new WaitForSecondsRealtime(0.2f);
        if (Llenguatges.languge == "VAL"){
            string value;
            Llenguatges.llenguatges.TryGetValue("VAL-Start",out value);
            GameObject.Find("Button").GetComponentInChildren<Text>().text = value;
            Llenguatges.llenguatges.TryGetValue("VAL-Infinit",out value);
            GameObject.Find("Infinit").GetComponentInChildren<Text>().text = value;
            Llenguatges.llenguatges.TryGetValue("VAL-Idioma", out value);
            GameObject.Find("Idioma").GetComponentInChildren<Text>().text = value;
            Debug.Log(value);
        }
        if (Llenguatges.languge == "ESP"){
            string value;
            Llenguatges.llenguatges.TryGetValue("ESP-Start",out value);
            GameObject.Find("Button").GetComponentInChildren<Text>().text = value;
            Llenguatges.llenguatges.TryGetValue("ESP-Infinit",out value);
            GameObject.Find("Infinit").GetComponentInChildren<Text>().text = value;
            Llenguatges.llenguatges.TryGetValue("ESP-Idioma", out value);
            GameObject.Find("Idioma").GetComponentInChildren<Text>().text = value;
            Debug.Log(value);
        }
        if (Llenguatges.languge == "ENG"){
            string value;
            Llenguatges.llenguatges.TryGetValue("ENG-Start",out value);
            GameObject.Find("Button").GetComponentInChildren<Text>().text = value;
            Llenguatges.llenguatges.TryGetValue("ENG-Infinit",out value);
            GameObject.Find("Infinit").GetComponentInChildren<Text>().text = value;
            Llenguatges.llenguatges.TryGetValue("ENG-Idioma", out value);
            GameObject.Find("Idioma").GetComponentInChildren<Text>().text = value;
            Debug.Log(value);
        }
        if (Llenguatges.languge == "ROM"){
            string value;
            Llenguatges.llenguatges.TryGetValue("ROM-Start",out value);
            GameObject.Find("Button").GetComponentInChildren<Text>().text = value;
            Llenguatges.llenguatges.TryGetValue("ROM-Infinit",out value);
            GameObject.Find("Infinit").GetComponentInChildren<Text>().text = value;
            Llenguatges.llenguatges.TryGetValue("ROM-Idioma", out value);
            GameObject.Find("Idioma").GetComponentInChildren<Text>().text = value;
            Debug.Log(value);
        }
        if (Llenguatges.languge == "UKR"){
            string value;
            Llenguatges.llenguatges.TryGetValue("UKR-Start",out value);
            GameObject.Find("Button").GetComponentInChildren<Text>().text = value;
            Llenguatges.llenguatges.TryGetValue("UKR-Infinit",out value);
            GameObject.Find("Infinit").GetComponentInChildren<Text>().text = value;
            Llenguatges.llenguatges.TryGetValue("UKR-Idioma", out value);
            GameObject.Find("Idioma").GetComponentInChildren<Text>().text = value;
            Debug.Log(value);
        }
        if (Llenguatges.languge == "RUS"){
            string value;
            Llenguatges.llenguatges.TryGetValue("RUS-Start",out value);
            GameObject.Find("Button").GetComponentInChildren<Text>().text = value;
            Llenguatges.llenguatges.TryGetValue("RUS-Infinit",out value);
            GameObject.Find("Infinit").GetComponentInChildren<Text>().text = value;
            Llenguatges.llenguatges.TryGetValue("RUS-Idioma", out value);
            GameObject.Find("Idioma").GetComponentInChildren<Text>().text = value;
            Debug.Log(value);
        }
    }
}
