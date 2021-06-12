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
            string value;
            Llenguatges.llenguatges.TryGetValue(Llenguatges.languge+"-Start",out value);
            GameObject.Find("Button").GetComponentInChildren<Text>().text = value;
            Llenguatges.llenguatges.TryGetValue(Llenguatges.languge+"-Infinit",out value);
            GameObject.Find("Infinit").GetComponentInChildren<Text>().text = value;
            Llenguatges.llenguatges.TryGetValue(Llenguatges.languge+"-Idioma", out value);
            GameObject.Find("Idioma").GetComponentInChildren<Text>().text = value;
            Debug.Log(value);
    }
}
