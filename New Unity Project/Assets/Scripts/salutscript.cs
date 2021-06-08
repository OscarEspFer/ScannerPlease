using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class salutscript : MonoBehaviour
{
    // Start is called before the first frame update


    // Update is called once per frame
    public GameObject salutResult;
    public void OnButtonPress(){
        StartCoroutine(esperador());
    }
    IEnumerator esperador(){
        yield return new WaitForSecondsRealtime(1);
        salutResult.gameObject.SetActive(true);
    }
}
