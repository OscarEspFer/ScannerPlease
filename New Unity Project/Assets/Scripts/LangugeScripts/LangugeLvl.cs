using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class LangugeLvl : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject textPass;
    public GameObject textTraball;
    void Start()
    {
        if (Llenguatges.languge == "VAL"){
            string value;
            Llenguatges.llenguatges.TryGetValue("VAL-Ferramentes",out value);
            GameObject.Find("mes").GetComponentInChildren<Text>().text = value;
            Llenguatges.llenguatges.TryGetValue("VAL-Escaner",out value);
            GameObject.Find("scanejar").GetComponentInChildren<Text>().text = value;
            Llenguatges.llenguatges.TryGetValue("VAL-PCR",out value);
            GameObject.Find("Escaner de salut").GetComponentInChildren<Text>().text = value;
            Llenguatges.llenguatges.TryGetValue("VAL-Passaport",out value);
            textPass.GetComponent<UnityEngine.UI.Text>().text = value;
            Llenguatges.llenguatges.TryGetValue("VAL-Treball",out value);
            textTraball.GetComponent<UnityEngine.UI.Text>().text = value;
        }
        if (Llenguatges.languge == "ESP"){
            string value;
            Llenguatges.llenguatges.TryGetValue("ESP-Ferramentes",out value);
            GameObject.Find("mes").GetComponentInChildren<Text>().text = value;
            Llenguatges.llenguatges.TryGetValue("ESP-Escaner",out value);
            GameObject.Find("scanejar").GetComponentInChildren<Text>().text = value;
            Llenguatges.llenguatges.TryGetValue("ESP-PCR",out value);
            GameObject.Find("Escaner de salut").GetComponentInChildren<Text>().text = value;
            Llenguatges.llenguatges.TryGetValue("ESP-Passaport",out value);
            textPass.GetComponent<UnityEngine.UI.Text>().text = value;
            Llenguatges.llenguatges.TryGetValue("ESP-Treball",out value);
            textTraball.GetComponent<UnityEngine.UI.Text>().text = value;
        }
        if (Llenguatges.languge == "ENG"){
            string value;
            Llenguatges.llenguatges.TryGetValue("ENG-Ferramentes",out value);
            GameObject.Find("mes").GetComponentInChildren<Text>().text = value;
            Llenguatges.llenguatges.TryGetValue("ENG-Escaner",out value);
            GameObject.Find("scanejar").GetComponentInChildren<Text>().text = value;
            Llenguatges.llenguatges.TryGetValue("ENG-PCR",out value);
            GameObject.Find("Escaner de salut").GetComponentInChildren<Text>().text = value;
            Llenguatges.llenguatges.TryGetValue("ENG-Passaport",out value);
            textPass.GetComponent<UnityEngine.UI.Text>().text = value;
            Llenguatges.llenguatges.TryGetValue("ENG-Treball",out value);
            textTraball.GetComponent<UnityEngine.UI.Text>().text = value;
        }
        if (Llenguatges.languge == "ROM"){
            string value;
            Llenguatges.llenguatges.TryGetValue("ROM-Ferramentes",out value);
            GameObject.Find("mes").GetComponentInChildren<Text>().text = value;
            Llenguatges.llenguatges.TryGetValue("ROM-Escaner",out value);
            GameObject.Find("scanejar").GetComponentInChildren<Text>().text = value;
            Llenguatges.llenguatges.TryGetValue("ROM-PCR",out value);
            GameObject.Find("Escaner de salut").GetComponentInChildren<Text>().text = value;
            Llenguatges.llenguatges.TryGetValue("ROM-Passaport",out value);
            textPass.GetComponent<UnityEngine.UI.Text>().text = value;
            Llenguatges.llenguatges.TryGetValue("ROM-Treball",out value);
            textTraball.GetComponent<UnityEngine.UI.Text>().text = value;
        }
        if (Llenguatges.languge == "UKR"){
            string value;
            Llenguatges.llenguatges.TryGetValue("UKR-Ferramentes",out value);
            GameObject.Find("mes").GetComponentInChildren<Text>().text = value;
            Llenguatges.llenguatges.TryGetValue("UKR-Escaner",out value);
            GameObject.Find("scanejar").GetComponentInChildren<Text>().text = value;
            Llenguatges.llenguatges.TryGetValue("UKR-PCR",out value);
            GameObject.Find("Escaner de salut").GetComponentInChildren<Text>().text = value;
            Llenguatges.llenguatges.TryGetValue("UKR-Passaport",out value);
            textPass.GetComponent<UnityEngine.UI.Text>().text = value;
            Llenguatges.llenguatges.TryGetValue("UKR-Treball",out value);
            textTraball.GetComponent<UnityEngine.UI.Text>().text = value;
        }
        if (Llenguatges.languge == "RUS"){
            string value;
            Llenguatges.llenguatges.TryGetValue("RUS-Ferramentes",out value);
            GameObject.Find("mes").GetComponentInChildren<Text>().text = value;
            Llenguatges.llenguatges.TryGetValue("RUS-Escaner",out value);
            GameObject.Find("scanejar").GetComponentInChildren<Text>().text = value;
            Llenguatges.llenguatges.TryGetValue("RUS-PCR",out value);
            GameObject.Find("Escaner de salut").GetComponentInChildren<Text>().text = value;
            Llenguatges.llenguatges.TryGetValue("RUS-Passaport",out value);
            textPass.GetComponent<UnityEngine.UI.Text>().text = value;
            Llenguatges.llenguatges.TryGetValue("RUS-Treball",out value);
            textTraball.GetComponent<UnityEngine.UI.Text>().text = value;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
