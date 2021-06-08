using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CarregarScore : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject text;
    void Start()
    {
        Data.Load();
        
    }

    // Update is called once per frame
    void Update()
    {
        text.GetComponent<UnityEngine.UI.Text>().text = ""+Temps.score;
    }
}
