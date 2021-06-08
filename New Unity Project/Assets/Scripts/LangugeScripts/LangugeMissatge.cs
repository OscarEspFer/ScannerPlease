using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LangugeMissatge : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject text;
    public string lvl;
    void Start()
    {
        if (Llenguatges.languge == "VAL"){
            string value;
            Llenguatges.llenguatges.TryGetValue("VAL-OK",out value);
            GameObject.Find("Button").GetComponentInChildren<Text>().text = value;
            Llenguatges.llenguatges.TryGetValue("VAL-Intro"+lvl,out value);
            text.GetComponent<UnityEngine.UI.Text>().text = value;
        }
        if (Llenguatges.languge == "ESP"){
            string value;
            Llenguatges.llenguatges.TryGetValue("ESP-OK",out value);
            GameObject.Find("Button").GetComponentInChildren<Text>().text = value;
            Llenguatges.llenguatges.TryGetValue("ESP-Intro"+lvl,out value);
            text.GetComponent<UnityEngine.UI.Text>().text = value;
        }
        if (Llenguatges.languge == "ENG"){
            string value;
            Llenguatges.llenguatges.TryGetValue("ENG-OK",out value);
            GameObject.Find("Button").GetComponentInChildren<Text>().text = value;
            Llenguatges.llenguatges.TryGetValue("ENG-Intro"+lvl,out value);
            text.GetComponent<UnityEngine.UI.Text>().text = value;
        }
        if (Llenguatges.languge == "ROM"){
            string value;
            Llenguatges.llenguatges.TryGetValue("ROM-OK",out value);
            GameObject.Find("Button").GetComponentInChildren<Text>().text = value;
            Llenguatges.llenguatges.TryGetValue("ROM-Intro"+lvl,out value);
            text.GetComponent<UnityEngine.UI.Text>().text = value;
        }
        if (Llenguatges.languge == "UKR"){
            string value;
            Llenguatges.llenguatges.TryGetValue("UKR-OK",out value);
            GameObject.Find("Button").GetComponentInChildren<Text>().text = value;
            Llenguatges.llenguatges.TryGetValue("UKR-Intro"+lvl,out value);
            text.GetComponent<UnityEngine.UI.Text>().text = value;
        }
        if (Llenguatges.languge == "RUS"){
            string value;
            Llenguatges.llenguatges.TryGetValue("RUS-OK",out value);
            GameObject.Find("Button").GetComponentInChildren<Text>().text = value;
            Llenguatges.llenguatges.TryGetValue("RUS-Intro"+lvl,out value);
            text.GetComponent<UnityEngine.UI.Text>().text = value;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
