using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LangugeSelector : MonoBehaviour
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
        yield return new WaitForSecondsRealtime(0.0f);
        if (Llenguatges.languge == "VAL"){
            string value;
            Llenguatges.llenguatges.TryGetValue("VAL-Back",out value);
            GameObject.Find("Enrere").GetComponentInChildren<Text>().text = value;
        }
        if (Llenguatges.languge == "ESP"){
            string value;
            Llenguatges.llenguatges.TryGetValue("ESP-Back",out value);
            GameObject.Find("Enrere").GetComponentInChildren<Text>().text = value;
        }
        if (Llenguatges.languge == "ENG"){
            string value;
            Llenguatges.llenguatges.TryGetValue("ENG-Back",out value);
            GameObject.Find("Enrere").GetComponentInChildren<Text>().text = value;
        }
        if (Llenguatges.languge == "ROM"){
            string value;
            Llenguatges.llenguatges.TryGetValue("ROM-Back",out value);
            GameObject.Find("Enrere").GetComponentInChildren<Text>().text = value;
        }
        if (Llenguatges.languge == "UKR"){
            string value;
            Llenguatges.llenguatges.TryGetValue("UKR-Back",out value);
            GameObject.Find("Enrere").GetComponentInChildren<Text>().text = value;
        }
        if (Llenguatges.languge == "RUS"){
            string value;
            Llenguatges.llenguatges.TryGetValue("RUS-Back",out value);
            GameObject.Find("Enrere").GetComponentInChildren<Text>().text = value;
        }
    }
}
