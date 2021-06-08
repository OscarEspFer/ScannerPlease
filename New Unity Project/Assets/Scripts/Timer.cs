using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    
    public GameObject timerText;
    private float timer;
    // Update is called once per frame
    void Start() {
        timer = Temps.temps;
    }
    void Update()
    {
        if (timer > 0){
            timer -= Time.deltaTime;
            timerText.GetComponent<UnityEngine.UI.Text>().text = timer+"s";
        }
    }
}
