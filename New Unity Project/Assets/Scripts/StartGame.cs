using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
    // Start is called before the first frame update
    public string Nivell;
    public string Nivell2;

    public static int infinit=0;
    void Start()
    {
        Data.Load();
        if (SceneManager.GetActiveScene().name == "Menu" && infinit == 1){
            GameObject.Find("Infinit").GetComponent<UnityEngine.UI.Button>().interactable = true;
        }
        else{
            GameObject.Find("Infinit").GetComponent<UnityEngine.UI.Button>().interactable = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnButtonPress(){
        SceneManager.LoadScene(Nivell);
    }
    public void OnButtonPress2(){
        SceneManager.LoadScene(Nivell2);
    }
}
