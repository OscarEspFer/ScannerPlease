using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class showhide : MonoBehaviour
{
    public bool show = true;
    public Canvas passport;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (show){
            passport.GetComponent<Canvas>().enabled = true;
        }else{
            passport.GetComponent<Canvas>().enabled = false;
        }
    }
}
